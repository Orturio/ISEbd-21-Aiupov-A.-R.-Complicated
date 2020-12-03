using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DrawAirplan
{
    class AerodromeCollection
    {
        readonly Dictionary<string, Aerodrome<Vehicle, DrawPortholeCircle>> aerodromeStages;

        public List<string> Keys => aerodromeStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public AerodromeCollection(int pictureWidth, int pictureHeight)
        {
            aerodromeStages = new Dictionary<string, Aerodrome<Vehicle, DrawPortholeCircle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                return;
            }
            aerodromeStages.Add(name, new Aerodrome<Vehicle, DrawPortholeCircle>(pictureWidth, pictureHeight));
        }

        public void DelAerodrome(string name)
        {
            if (aerodromeStages.ContainsKey(name))
            {
                aerodromeStages.Remove(name);
            }
        }

        public Aerodrome<Vehicle, DrawPortholeCircle> this[string ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(ind))
                {
                    return aerodromeStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public Vehicle this[string key, int ind]
        {
            get
            {
                if (aerodromeStages.ContainsKey(key) && ind > -1)
                {                    
                    return aerodromeStages[key]._places[ind];
                }
                else
                {
                    return null;
                }
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.Write($"AerodromeCollection{Environment.NewLine}", fs);
                    foreach (var level in aerodromeStages)
                    {
                        //Начинаем парковку
                        writer.Write($"Aerodrome{separator}{level.Key}{Environment.NewLine}", fs);
                        ITransport aircraft = null;
                        for (int i = 0; (aircraft = level.Value[i]) != null; i++)
                        {
                            if (aircraft != null)
                            {
                                //если место не пустое
                                //Записываем тип машины
                                if (aircraft.GetType().Name == "Aircraft")
                                {
                                    writer.Write($"Aircraft{separator}", fs);
                                }
                                if (aircraft.GetType().Name == "Airbus")
                                {
                                    writer.Write($"Airbus{separator}", fs);
                                }
                                //Записываемые параметры
                                writer.Write(aircraft + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool SaveOneLevel(string filename, string aerodromeName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (aerodromeStages.ContainsKey(aerodromeName))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine($"OneAerodrome");

                        sw.WriteLine($"Aerodrome{separator}{aerodromeName}");
                        ITransport aircraft = null;
                        var level = aerodromeStages[aerodromeName];

                        for (int i = 0; (aircraft = level[i]) != null; i++)
                        {
                            if (aircraft != null)
                            {
                                if (aircraft.GetType().Name == "Aircraft")
                                {
                                    sw.Write($"Aircraft{separator}");

                                }
                                if (aircraft.GetType().Name == "Airbus")
                                {
                                    sw.Write($"Airbus{separator}");
                                }
                                //Записываемые параметры
                                sw.WriteLine(aircraft);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename, bool loadType)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AerodromeCollection") && loadType)
                {
                    //очищаем записи
                    aerodromeStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                line = sr.ReadLine();
                Vehicle aircraft = null;
                string key = string.Empty;
                while (line != null && line.Contains("Aerodrome"))
                {
                    key = line.Split(separator)[1];
                    aerodromeStages.Add(key, new Aerodrome<Vehicle, DrawPortholeCircle>(pictureWidth,
                    pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Aircraft") || line.Contains("Airbus")))
                    {
                        if (line.Split(separator)[0] == "Aircraft")
                        {
                            aircraft = new Aircraft(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Airbus")
                        {
                            aircraft = new Airbus(line.Split(separator)[1]);
                        }
                        var result = aerodromeStages[key] + aircraft;
                        if (!result)
                        {
                            return false;
                        }
                        line = sr.ReadLine();
                    }
                }
                return true;
            }
        }

        public bool LoadOneLevel(string filename, bool loadType)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("OneAerodrome") && !loadType)
                {
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }

                line = sr.ReadLine();
                Vehicle aircraft = null;
                string key = string.Empty;

                while (line != null && line.Contains("Aerodrome"))
                {
                    key = line.Split(separator)[1];
                    aerodromeStages.Add(key, new Aerodrome<Vehicle, DrawPortholeCircle>(pictureWidth, pictureHeight));
                    if (aerodromeStages.ContainsKey(key))
                    {
                        aerodromeStages[key].ClearStages();
                    }
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Aircraft") || line.Contains("Airbus")))
                    {
                        if (line.Split(separator)[0] == "Aircraft")
                        {
                            aircraft = new Aircraft(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Airbus")
                        {
                            aircraft = new Airbus(line.Split(separator)[1]);
                        }
                        line = sr.ReadLine();
                        var result = aerodromeStages[key] + aircraft;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}