namespace DrawAirplan
{
    partial class FormAerodrome
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
            this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
            this.buttonLandAircraft = new System.Windows.Forms.Button();
            this.buttonLandAirbus = new System.Windows.Forms.Button();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelAerodromes = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddAerodrome = new System.Windows.Forms.Button();
            this.listBoxAerodromes = new System.Windows.Forms.ListBox();
            this.buttonDeleteAerodrome = new System.Windows.Forms.Button();
            this.buttonPlainsCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.groupBoxAircraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(-1, 1);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(799, 450);
            this.pictureBoxAerodrome.TabIndex = 0;
            this.pictureBoxAerodrome.TabStop = false;
            // 
            // buttonLandAircraft
            // 
            this.buttonLandAircraft.Location = new System.Drawing.Point(675, 259);
            this.buttonLandAircraft.Name = "buttonLandAircraft";
            this.buttonLandAircraft.Size = new System.Drawing.Size(109, 35);
            this.buttonLandAircraft.TabIndex = 1;
            this.buttonLandAircraft.Text = "Посадить самолёт";
            this.buttonLandAircraft.UseVisualStyleBackColor = true;
            this.buttonLandAircraft.Click += new System.EventHandler(this.buttonLandAircraft_Click);
            // 
            // buttonLandAirbus
            // 
            this.buttonLandAirbus.Location = new System.Drawing.Point(675, 300);
            this.buttonLandAirbus.Name = "buttonLandAirbus";
            this.buttonLandAirbus.Size = new System.Drawing.Size(109, 36);
            this.buttonLandAirbus.TabIndex = 2;
            this.buttonLandAirbus.Text = "Посадить аэробус";
            this.buttonLandAirbus.UseVisualStyleBackColor = true;
            this.buttonLandAirbus.Click += new System.EventHandler(this.buttonLandAirbus_Click);
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.buttonPlainsCheck);
            this.groupBoxAircraft.Controls.Add(this.buttonTakeAircraft);
            this.groupBoxAircraft.Controls.Add(this.maskedTextBox);
            this.groupBoxAircraft.Controls.Add(this.labelPlace);
            this.groupBoxAircraft.Location = new System.Drawing.Point(607, 342);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(177, 96);
            this.groupBoxAircraft.TabIndex = 3;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Забрать самолёт";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(15, 63);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(77, 27);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(98, 37);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(50, 40);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelAerodromes
            // 
            this.labelAerodromes.AutoSize = true;
            this.labelAerodromes.Location = new System.Drawing.Point(697, 9);
            this.labelAerodromes.Name = "labelAerodromes";
            this.labelAerodromes.Size = new System.Drawing.Size(69, 13);
            this.labelAerodromes.TabIndex = 4;
            this.labelAerodromes.Text = "Аэродромы:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(675, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(109, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // buttonAddAerodrome
            // 
            this.buttonAddAerodrome.Location = new System.Drawing.Point(675, 51);
            this.buttonAddAerodrome.Name = "buttonAddAerodrome";
            this.buttonAddAerodrome.Size = new System.Drawing.Size(109, 35);
            this.buttonAddAerodrome.TabIndex = 6;
            this.buttonAddAerodrome.Text = "Добавить аэродром";
            this.buttonAddAerodrome.UseVisualStyleBackColor = true;
            this.buttonAddAerodrome.Click += new System.EventHandler(this.buttonAddAerodrome_Click);
            // 
            // listBoxAerodromes
            // 
            this.listBoxAerodromes.FormattingEnabled = true;
            this.listBoxAerodromes.Location = new System.Drawing.Point(675, 92);
            this.listBoxAerodromes.Name = "listBoxAerodromes";
            this.listBoxAerodromes.Size = new System.Drawing.Size(109, 95);
            this.listBoxAerodromes.TabIndex = 7;
            this.listBoxAerodromes.Click += new System.EventHandler(this.listBoxAerodrome_SelectedIndexChanged);
            // 
            // buttonDeleteAerodrome
            // 
            this.buttonDeleteAerodrome.Location = new System.Drawing.Point(675, 193);
            this.buttonDeleteAerodrome.Name = "buttonDeleteAerodrome";
            this.buttonDeleteAerodrome.Size = new System.Drawing.Size(109, 44);
            this.buttonDeleteAerodrome.TabIndex = 8;
            this.buttonDeleteAerodrome.Text = "Удалить аэродром";
            this.buttonDeleteAerodrome.UseVisualStyleBackColor = true;
            this.buttonDeleteAerodrome.Click += new System.EventHandler(this.buttonDeleteAerodrome_Click);
            // 
            // buttonPlainsCheck
            // 
            this.buttonPlainsCheck.Location = new System.Drawing.Point(93, 63);
            this.buttonPlainsCheck.Name = "buttonPlainsCheck";
            this.buttonPlainsCheck.Size = new System.Drawing.Size(78, 27);
            this.buttonPlainsCheck.TabIndex = 9;
            this.buttonPlainsCheck.Text = "Посмотреть";
            this.buttonPlainsCheck.UseVisualStyleBackColor = true;
            this.buttonPlainsCheck.Click += new System.EventHandler(this.buttonPlainsCheck_Click);
            // 
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteAerodrome);
            this.Controls.Add(this.listBoxAerodromes);
            this.Controls.Add(this.buttonAddAerodrome);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.labelAerodromes);
            this.Controls.Add(this.groupBoxAircraft);
            this.Controls.Add(this.buttonLandAirbus);
            this.Controls.Add(this.buttonLandAircraft);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Name = "FormAerodrome";
            this.Text = "FormAerodrome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.groupBoxAircraft.ResumeLayout(false);
            this.groupBoxAircraft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonLandAircraft;
        private System.Windows.Forms.Button buttonLandAirbus;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelAerodromes;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddAerodrome;
        private System.Windows.Forms.ListBox listBoxAerodromes;
        private System.Windows.Forms.Button buttonDeleteAerodrome;
        private System.Windows.Forms.Button buttonPlainsCheck;
    }
}