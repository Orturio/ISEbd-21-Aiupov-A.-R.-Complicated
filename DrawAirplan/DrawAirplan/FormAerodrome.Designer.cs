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
            this.buttonLandAircraft = new System.Windows.Forms.Button();
            this.buttonLandAirbus = new System.Windows.Forms.Button();
            this.groupBoxAircraft = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxAerodrome = new System.Windows.Forms.PictureBox();
            this.groupBoxCompare = new System.Windows.Forms.GroupBox();
            this.buttonCompareForSimilarAicrafts = new System.Windows.Forms.Button();
            this.maskedTextBoxCompareForSimilarity = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUniqChecking = new System.Windows.Forms.Button();
            this.groupBoxAircraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).BeginInit();
            this.groupBoxCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLandAircraft
            // 
            this.buttonLandAircraft.Location = new System.Drawing.Point(665, 12);
            this.buttonLandAircraft.Name = "buttonLandAircraft";
            this.buttonLandAircraft.Size = new System.Drawing.Size(123, 37);
            this.buttonLandAircraft.TabIndex = 3;
            this.buttonLandAircraft.Text = "Посадить самолёт";
            this.buttonLandAircraft.UseVisualStyleBackColor = true;
            this.buttonLandAircraft.Click += new System.EventHandler(this.buttonLandAircraft_Click);
            // 
            // buttonLandAirbus
            // 
            this.buttonLandAirbus.Location = new System.Drawing.Point(665, 55);
            this.buttonLandAirbus.Name = "buttonLandAirbus";
            this.buttonLandAirbus.Size = new System.Drawing.Size(123, 37);
            this.buttonLandAirbus.TabIndex = 4;
            this.buttonLandAirbus.Text = "Посадить аэробус";
            this.buttonLandAirbus.UseVisualStyleBackColor = true;
            this.buttonLandAirbus.Click += new System.EventHandler(this.buttonLandAirbus_Click);
            // 
            // groupBoxAircraft
            // 
            this.groupBoxAircraft.Controls.Add(this.buttonTakeAircraft);
            this.groupBoxAircraft.Controls.Add(this.maskedTextBox);
            this.groupBoxAircraft.Controls.Add(this.labelPlace);
            this.groupBoxAircraft.Location = new System.Drawing.Point(665, 98);
            this.groupBoxAircraft.Name = "groupBoxAircraft";
            this.groupBoxAircraft.Size = new System.Drawing.Size(123, 121);
            this.groupBoxAircraft.TabIndex = 5;
            this.groupBoxAircraft.TabStop = false;
            this.groupBoxAircraft.Text = "Забрать самолёт";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(14, 81);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(99, 34);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(56, 38);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(57, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(11, 41);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(39, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место";
            // 
            // pictureBoxAerodrome
            // 
            this.pictureBoxAerodrome.Location = new System.Drawing.Point(-6, -2);
            this.pictureBoxAerodrome.Name = "pictureBoxAerodrome";
            this.pictureBoxAerodrome.Size = new System.Drawing.Size(801, 452);
            this.pictureBoxAerodrome.TabIndex = 2;
            this.pictureBoxAerodrome.TabStop = false;
            // 
            // groupBoxCompare
            // 
            this.groupBoxCompare.Controls.Add(this.buttonUniqChecking);
            this.groupBoxCompare.Controls.Add(this.label1);
            this.groupBoxCompare.Controls.Add(this.maskedTextBoxCompareForSimilarity);
            this.groupBoxCompare.Controls.Add(this.buttonCompareForSimilarAicrafts);
            this.groupBoxCompare.Location = new System.Drawing.Point(665, 225);
            this.groupBoxCompare.Name = "groupBoxCompare";
            this.groupBoxCompare.Size = new System.Drawing.Size(123, 195);
            this.groupBoxCompare.TabIndex = 6;
            this.groupBoxCompare.TabStop = false;
            this.groupBoxCompare.Text = "Сравнить";
            // 
            // buttonCompareForSimilarAicrafts
            // 
            this.buttonCompareForSimilarAicrafts.Location = new System.Drawing.Point(14, 52);
            this.buttonCompareForSimilarAicrafts.Name = "buttonCompareForSimilarAicrafts";
            this.buttonCompareForSimilarAicrafts.Size = new System.Drawing.Size(99, 57);
            this.buttonCompareForSimilarAicrafts.TabIndex = 0;
            this.buttonCompareForSimilarAicrafts.Text = "Сравнить самолёт на схожесть";
            this.buttonCompareForSimilarAicrafts.UseVisualStyleBackColor = true;
            this.buttonCompareForSimilarAicrafts.Click += new System.EventHandler(this.buttonCompareForSimilarAicrafts_Click);
            // 
            // maskedTextBoxCompareForSimilarity
            // 
            this.maskedTextBoxCompareForSimilarity.Location = new System.Drawing.Point(56, 26);
            this.maskedTextBoxCompareForSimilarity.Name = "maskedTextBoxCompareForSimilarity";
            this.maskedTextBoxCompareForSimilarity.Size = new System.Drawing.Size(57, 20);
            this.maskedTextBoxCompareForSimilarity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер";
            // 
            // buttonUniqChecking
            // 
            this.buttonUniqChecking.Location = new System.Drawing.Point(14, 115);
            this.buttonUniqChecking.Name = "buttonUniqChecking";
            this.buttonUniqChecking.Size = new System.Drawing.Size(99, 55);
            this.buttonUniqChecking.TabIndex = 4;
            this.buttonUniqChecking.Text = "Проверка на уникальность";
            this.buttonUniqChecking.UseVisualStyleBackColor = true;
            this.buttonUniqChecking.Click += new System.EventHandler(this.buttonUniqChecking_Click);
            // 
            // FormAerodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCompare);
            this.Controls.Add(this.groupBoxAircraft);
            this.Controls.Add(this.buttonLandAirbus);
            this.Controls.Add(this.buttonLandAircraft);
            this.Controls.Add(this.pictureBoxAerodrome);
            this.Name = "FormAerodrome";
            this.Text = "FormAerodrome";
            this.groupBoxAircraft.ResumeLayout(false);
            this.groupBoxAircraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrome)).EndInit();
            this.groupBoxCompare.ResumeLayout(false);
            this.groupBoxCompare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrome;
        private System.Windows.Forms.Button buttonLandAircraft;
        private System.Windows.Forms.Button buttonLandAirbus;
        private System.Windows.Forms.GroupBox groupBoxAircraft;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.GroupBox groupBoxCompare;
        private System.Windows.Forms.Button buttonCompareForSimilarAicrafts;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompareForSimilarity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUniqChecking;
    }
}