namespace DrawAirplan
{
    partial class FormAircraftConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxLowerWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxDopChassie = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.labelAirbus = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.panelAircraft = new System.Windows.Forms.Panel();
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxAircraftFeatures = new System.Windows.Forms.GroupBox();
            this.labelChangePortholes = new System.Windows.Forms.Label();
            this.labelTrianglePortholes = new System.Windows.Forms.Label();
            this.labelRectanglePortholes = new System.Windows.Forms.Label();
            this.labelCirclePortholes = new System.Windows.Forms.Label();
            this.labelThirtyPortholes = new System.Windows.Forms.Label();
            this.labelTwentyPortholes = new System.Windows.Forms.Label();
            this.labelTenPortholes = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxAircraft.SuspendLayout();
            this.panelAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxAircraftFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxLowerWindows);
            this.groupBoxParameters.Controls.Add(this.checkBoxDopChassie);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 127);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(225, 118);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxLowerWindows
            // 
            this.checkBoxLowerWindows.AutoSize = true;
            this.checkBoxLowerWindows.Checked = true;
            this.checkBoxLowerWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLowerWindows.Location = new System.Drawing.Point(133, 80);
            this.checkBoxLowerWindows.Name = "checkBoxLowerWindows";
            this.checkBoxLowerWindows.Size = new System.Drawing.Size(93, 17);
            this.checkBoxLowerWindows.TabIndex = 5;
            this.checkBoxLowerWindows.Text = "Нижние окна";
            this.checkBoxLowerWindows.UseVisualStyleBackColor = true;
            // 
            // checkBoxDopChassie
            // 
            this.checkBoxDopChassie.AutoSize = true;
            this.checkBoxDopChassie.Checked = true;
            this.checkBoxDopChassie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDopChassie.Location = new System.Drawing.Point(133, 33);
            this.checkBoxDopChassie.Name = "checkBoxDopChassie";
            this.checkBoxDopChassie.Size = new System.Drawing.Size(85, 17);
            this.checkBoxDopChassie.TabIndex = 4;
            this.checkBoxDopChassie.Text = "Доп. шасси";
            this.checkBoxDopChassie.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(53, 79);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(53, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес авто:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.labelAirbus);
            this.groupBoxAircraft.Controls.Add(this.labelAircraft);
            this.groupBoxAircraft.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(127, 109);
            this.groupBoxAircraft.TabIndex = 1;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Тип самолёта";
            // 
            // labelAirbus
            // 
            this.labelAirbus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirbus.Location = new System.Drawing.Point(6, 64);
            this.labelAirbus.Name = "labelAirbus";
            this.labelAirbus.Size = new System.Drawing.Size(115, 31);
            this.labelAirbus.TabIndex = 3;
            this.labelAirbus.Text = "Эйрбас";
            this.labelAirbus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirbus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirbus_MouseDown);
            // 
            // labelAircraft
            // 
            this.labelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraft.Location = new System.Drawing.Point(6, 25);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(115, 29);
            this.labelAircraft.TabIndex = 3;
            this.labelAircraft.Text = "Обычный самолёт";
            this.labelAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraft_MouseDown);
            // 
            // panelAircraft
            // 
            this.panelAircraft.AllowDrop = true;
            this.panelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAircraft.Controls.Add(this.pictureBoxAircraft);
            this.panelAircraft.Location = new System.Drawing.Point(145, 12);
            this.panelAircraft.Name = "panelAircraft";
            this.panelAircraft.Size = new System.Drawing.Size(256, 109);
            this.panelAircraft.TabIndex = 3;
            this.panelAircraft.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragDrop);
            this.panelAircraft.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAircraft_DragEnter);
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAircraft.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(248, 102);
            this.pictureBoxAircraft.TabIndex = 4;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelLime);
            this.groupBoxColors.Controls.Add(this.panelFuchsia);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelAqua);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Location = new System.Drawing.Point(407, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(176, 157);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLime.Location = new System.Drawing.Point(129, 112);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(35, 35);
            this.panelLime.TabIndex = 9;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Location = new System.Drawing.Point(88, 112);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(35, 35);
            this.panelFuchsia.TabIndex = 8;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.ForeColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(47, 112);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(35, 35);
            this.panelGray.TabIndex = 7;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(6, 112);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 6;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(129, 71);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(35, 35);
            this.panelBlue.TabIndex = 5;
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(88, 71);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(35, 35);
            this.panelAqua.TabIndex = 4;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 25);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(76, 34);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(47, 71);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 71);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(88, 25);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(76, 34);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(495, 175);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(88, 32);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(495, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 31);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxAircraftFeatures
            // 
            this.groupBoxAircraftFeatures.Controls.Add(this.labelChangePortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelTrianglePortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelRectanglePortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelCirclePortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelThirtyPortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelTwentyPortholes);
            this.groupBoxAircraftFeatures.Controls.Add(this.labelTenPortholes);
            this.groupBoxAircraftFeatures.Location = new System.Drawing.Point(243, 133);
            this.groupBoxAircraftFeatures.Name = "groupBoxAircraftFeatures";
            this.groupBoxAircraftFeatures.Size = new System.Drawing.Size(158, 149);
            this.groupBoxAircraftFeatures.TabIndex = 7;
            this.groupBoxAircraftFeatures.TabStop = false;
            this.groupBoxAircraftFeatures.Text = "Хар-ки самолёта";
            // 
            // labelChangePortholes
            // 
            this.labelChangePortholes.AllowDrop = true;
            this.labelChangePortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChangePortholes.Location = new System.Drawing.Point(28, 20);
            this.labelChangePortholes.Name = "labelChangePortholes";
            this.labelChangePortholes.Size = new System.Drawing.Size(109, 28);
            this.labelChangePortholes.TabIndex = 13;
            this.labelChangePortholes.Text = "Изменить окна";
            this.labelChangePortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChangePortholes.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelChangePortholes_DragDrop);
            this.labelChangePortholes.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelChangePortholes_DragEnter);
            // 
            // labelTrianglePortholes
            // 
            this.labelTrianglePortholes.AllowDrop = true;
            this.labelTrianglePortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrianglePortholes.Location = new System.Drawing.Point(76, 119);
            this.labelTrianglePortholes.Name = "labelTrianglePortholes";
            this.labelTrianglePortholes.Size = new System.Drawing.Size(76, 27);
            this.labelTrianglePortholes.TabIndex = 12;
            this.labelTrianglePortholes.Text = "Triangle";
            this.labelTrianglePortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrianglePortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPortholesForm_MouseDown);
            // 
            // labelRectanglePortholes
            // 
            this.labelRectanglePortholes.AllowDrop = true;
            this.labelRectanglePortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRectanglePortholes.Location = new System.Drawing.Point(76, 85);
            this.labelRectanglePortholes.Name = "labelRectanglePortholes";
            this.labelRectanglePortholes.Size = new System.Drawing.Size(76, 27);
            this.labelRectanglePortholes.TabIndex = 11;
            this.labelRectanglePortholes.Text = "Rectangle";
            this.labelRectanglePortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRectanglePortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPortholesForm_MouseDown);
            // 
            // labelCirclePortholes
            // 
            this.labelCirclePortholes.AllowDrop = true;
            this.labelCirclePortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCirclePortholes.Location = new System.Drawing.Point(76, 53);
            this.labelCirclePortholes.Name = "labelCirclePortholes";
            this.labelCirclePortholes.Size = new System.Drawing.Size(76, 27);
            this.labelCirclePortholes.TabIndex = 10;
            this.labelCirclePortholes.Text = "Circle";
            this.labelCirclePortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCirclePortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPortholesForm_MouseDown);
            // 
            // labelThirtyPortholes
            // 
            this.labelThirtyPortholes.AllowDrop = true;
            this.labelThirtyPortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThirtyPortholes.Location = new System.Drawing.Point(17, 119);
            this.labelThirtyPortholes.Name = "labelThirtyPortholes";
            this.labelThirtyPortholes.Size = new System.Drawing.Size(47, 27);
            this.labelThirtyPortholes.TabIndex = 9;
            this.labelThirtyPortholes.Text = "30";
            this.labelThirtyPortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThirtyPortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPortholesCount_MouseDown);
            // 
            // labelTwentyPortholes
            // 
            this.labelTwentyPortholes.AllowDrop = true;
            this.labelTwentyPortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTwentyPortholes.Location = new System.Drawing.Point(17, 85);
            this.labelTwentyPortholes.Name = "labelTwentyPortholes";
            this.labelTwentyPortholes.Size = new System.Drawing.Size(47, 27);
            this.labelTwentyPortholes.TabIndex = 8;
            this.labelTwentyPortholes.Text = "20";
            this.labelTwentyPortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTwentyPortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPortholesCount_MouseDown);
            // 
            // labelTenPortholes
            // 
            this.labelTenPortholes.AllowDrop = true;
            this.labelTenPortholes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTenPortholes.Location = new System.Drawing.Point(17, 53);
            this.labelTenPortholes.Name = "labelTenPortholes";
            this.labelTenPortholes.Size = new System.Drawing.Size(47, 27);
            this.labelTenPortholes.TabIndex = 0;
            this.labelTenPortholes.Text = "10";
            this.labelTenPortholes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTenPortholes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPortholesCount_MouseDown);
            // 
            // FormAircraftConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 294);
            this.Controls.Add(this.groupBoxAircraftFeatures);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelAircraft);
            this.Controls.Add(this.groupBoxAircraft);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormAircraftConfig";
            this.Text = "FormAircraftConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxAircraft.ResumeLayout(false);
            this.panelAircraft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxAircraftFeatures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxLowerWindows;
        private System.Windows.Forms.CheckBox checkBoxDopChassie;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Label labelAirbus;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Panel panelAircraft;
        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxAircraftFeatures;
        private System.Windows.Forms.Label labelTenPortholes;
        private System.Windows.Forms.Label labelChangePortholes;
        private System.Windows.Forms.Label labelTrianglePortholes;
        private System.Windows.Forms.Label labelRectanglePortholes;
        private System.Windows.Forms.Label labelCirclePortholes;
        private System.Windows.Forms.Label labelThirtyPortholes;
        private System.Windows.Forms.Label labelTwentyPortholes;
    }
}