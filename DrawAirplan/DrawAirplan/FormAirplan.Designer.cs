namespace DrawAirplan
{
    partial class FormAirplan
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateAircraft = new System.Windows.Forms.Button();
            this.comboBoxWindowCount = new System.Windows.Forms.ComboBox();
            this.buttonCreateAirbus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDoorsCount = new System.Windows.Forms.ComboBox();
            this.labelDoorsCount = new System.Windows.Forms.Label();
            this.labelDoorsForm = new System.Windows.Forms.Label();
            this.checkedListBoxForm = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCountPortholes = new System.Windows.Forms.Label();
            this.buttonDoorEllipseForm = new System.Windows.Forms.Button();
            this.buttonDoorRectangleForm = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateAircraft
            // 
            this.buttonCreateAircraft.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateAircraft.Name = "buttonCreateAircraft";
            this.buttonCreateAircraft.Size = new System.Drawing.Size(130, 31);
            this.buttonCreateAircraft.TabIndex = 1;
            this.buttonCreateAircraft.Text = "Создать самолёт";
            this.buttonCreateAircraft.UseVisualStyleBackColor = true;
            this.buttonCreateAircraft.Click += new System.EventHandler(this.buttonCreateAircraft_Click);
            // 
            // comboBoxWindowCount
            // 
            this.comboBoxWindowCount.FormattingEnabled = true;
            this.comboBoxWindowCount.Location = new System.Drawing.Point(134, 28);
            this.comboBoxWindowCount.Name = "comboBoxWindowCount";
            this.comboBoxWindowCount.Size = new System.Drawing.Size(65, 21);
            this.comboBoxWindowCount.TabIndex = 6;
            // 
            // buttonCreateAirbus
            // 
            this.buttonCreateAirbus.Location = new System.Drawing.Point(148, 12);
            this.buttonCreateAirbus.Name = "buttonCreateAirbus";
            this.buttonCreateAirbus.Size = new System.Drawing.Size(130, 31);
            this.buttonCreateAirbus.TabIndex = 7;
            this.buttonCreateAirbus.Text = "Создать аэробус";
            this.buttonCreateAirbus.UseVisualStyleBackColor = true;
            this.buttonCreateAirbus.Click += new System.EventHandler(this.buttonCreateAirbus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDoorEllipseForm);
            this.groupBox1.Controls.Add(this.buttonDoorRectangleForm);
            this.groupBox1.Controls.Add(this.comboBoxDoorsCount);
            this.groupBox1.Controls.Add(this.labelDoorsCount);
            this.groupBox1.Controls.Add(this.labelDoorsForm);
            this.groupBox1.Controls.Add(this.checkedListBoxForm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCountPortholes);
            this.groupBox1.Controls.Add(this.comboBoxWindowCount);
            this.groupBox1.Location = new System.Drawing.Point(662, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "параметры самолёта";
            // 
            // comboBoxDoorsCount
            // 
            this.comboBoxDoorsCount.FormattingEnabled = true;
            this.comboBoxDoorsCount.Location = new System.Drawing.Point(98, 108);
            this.comboBoxDoorsCount.Name = "comboBoxDoorsCount";
            this.comboBoxDoorsCount.Size = new System.Drawing.Size(61, 21);
            this.comboBoxDoorsCount.TabIndex = 12;
            // 
            // labelDoorsCount
            // 
            this.labelDoorsCount.AutoSize = true;
            this.labelDoorsCount.Location = new System.Drawing.Point(9, 111);
            this.labelDoorsCount.Name = "labelDoorsCount";
            this.labelDoorsCount.Size = new System.Drawing.Size(83, 13);
            this.labelDoorsCount.TabIndex = 11;
            this.labelDoorsCount.Text = "Кол-во дверей:";
            // 
            // labelDoorsForm
            // 
            this.labelDoorsForm.AutoSize = true;
            this.labelDoorsForm.Location = new System.Drawing.Point(9, 142);
            this.labelDoorsForm.Name = "labelDoorsForm";
            this.labelDoorsForm.Size = new System.Drawing.Size(86, 13);
            this.labelDoorsForm.TabIndex = 10;
            this.labelDoorsForm.Text = "Форма дверей:";
            // 
            // checkedListBoxForm
            // 
            this.checkedListBoxForm.FormattingEnabled = true;
            this.checkedListBoxForm.Items.AddRange(new object[] {
            "Круг",
            "Квадрат"});
            this.checkedListBoxForm.Location = new System.Drawing.Point(135, 55);
            this.checkedListBoxForm.Name = "checkedListBoxForm";
            this.checkedListBoxForm.Size = new System.Drawing.Size(64, 34);
            this.checkedListBoxForm.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Форма иллюминаторов:";
            // 
            // labelCountPortholes
            // 
            this.labelCountPortholes.AutoSize = true;
            this.labelCountPortholes.Location = new System.Drawing.Point(6, 31);
            this.labelCountPortholes.Name = "labelCountPortholes";
            this.labelCountPortholes.Size = new System.Drawing.Size(128, 13);
            this.labelCountPortholes.TabIndex = 7;
            this.labelCountPortholes.Text = "Кол-во иллюминаторов:";
            // 
            // buttonDoorEllipseForm
            // 
            this.buttonDoorEllipseForm.BackgroundImage = global::DrawAirplan.Properties.Resources.iconfinder_record_round_circle_dot_2203520;
            this.buttonDoorEllipseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDoorEllipseForm.Location = new System.Drawing.Point(146, 135);
            this.buttonDoorEllipseForm.Name = "buttonDoorEllipseForm";
            this.buttonDoorEllipseForm.Size = new System.Drawing.Size(42, 27);
            this.buttonDoorEllipseForm.TabIndex = 14;
            this.buttonDoorEllipseForm.Text = "0";
            this.buttonDoorEllipseForm.UseVisualStyleBackColor = true;
            this.buttonDoorEllipseForm.Click += new System.EventHandler(this.buttonDoorForm_Click);
            // 
            // buttonDoorRectangleForm
            // 
            this.buttonDoorRectangleForm.BackgroundImage = global::DrawAirplan.Properties.Resources.square;
            this.buttonDoorRectangleForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDoorRectangleForm.Location = new System.Drawing.Point(98, 135);
            this.buttonDoorRectangleForm.Name = "buttonDoorRectangleForm";
            this.buttonDoorRectangleForm.Size = new System.Drawing.Size(42, 27);
            this.buttonDoorRectangleForm.TabIndex = 13;
            this.buttonDoorRectangleForm.Text = "1";
            this.buttonDoorRectangleForm.UseVisualStyleBackColor = true;
            this.buttonDoorRectangleForm.Click += new System.EventHandler(this.buttonDoorForm_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRight.BackgroundImage = global::DrawAirplan.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDown.BackgroundImage = global::DrawAirplan.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(806, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLeft.BackgroundImage = global::DrawAirplan.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(770, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUp.BackgroundImage = global::DrawAirplan.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(806, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAircraft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // FormAirplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateAirbus);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateAircraft);
            this.Controls.Add(this.pictureBoxAircraft);
            this.Name = "FormAirplan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airbus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.Button buttonCreateAircraft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.ComboBox comboBoxWindowCount;
        private System.Windows.Forms.Button buttonCreateAirbus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCountPortholes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxForm;
        private System.Windows.Forms.Label labelDoorsForm;
        private System.Windows.Forms.ComboBox comboBoxDoorsCount;
        private System.Windows.Forms.Label labelDoorsCount;
        private System.Windows.Forms.Button buttonDoorEllipseForm;
        private System.Windows.Forms.Button buttonDoorRectangleForm;
    }
}

