namespace BusControlApp
{
    partial class AddBus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.manufInputField = new System.Windows.Forms.ComboBox();
            this.companyInputField = new System.Windows.Forms.ComboBox();
            this.licenseInputField = new System.Windows.Forms.ComboBox();
            this.modelInputField = new System.Windows.Forms.TextBox();
            this.vinInputField = new System.Windows.Forms.TextBox();
            this.busNumberInputField = new System.Windows.Forms.TextBox();
            this.garageNumberInputField = new System.Windows.Forms.TextBox();
            this.tankVolumeInputField = new System.Windows.Forms.TextBox();
            this.prodYearInputField = new System.Windows.Forms.TextBox();
            this.mileageInputField = new System.Windows.Forms.TextBox();
            this.addBusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите VIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите производителя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите гаражный номер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Выберите перевозчика:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введите гос. номер:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Введите текущий пробег";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Выберите необходимую категорию прав:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Введите год производства:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Введите объем топливного бака:";
            // 
            // manufInputField
            // 
            this.manufInputField.FormattingEnabled = true;
            this.manufInputField.Location = new System.Drawing.Point(257, 44);
            this.manufInputField.Name = "manufInputField";
            this.manufInputField.Size = new System.Drawing.Size(201, 21);
            this.manufInputField.TabIndex = 10;
            // 
            // companyInputField
            // 
            this.companyInputField.FormattingEnabled = true;
            this.companyInputField.Location = new System.Drawing.Point(257, 123);
            this.companyInputField.Name = "companyInputField";
            this.companyInputField.Size = new System.Drawing.Size(201, 21);
            this.companyInputField.TabIndex = 11;
            // 
            // licenseInputField
            // 
            this.licenseInputField.FormattingEnabled = true;
            this.licenseInputField.Location = new System.Drawing.Point(257, 254);
            this.licenseInputField.Name = "licenseInputField";
            this.licenseInputField.Size = new System.Drawing.Size(201, 21);
            this.licenseInputField.TabIndex = 12;
            // 
            // modelInputField
            // 
            this.modelInputField.Location = new System.Drawing.Point(257, 71);
            this.modelInputField.Name = "modelInputField";
            this.modelInputField.Size = new System.Drawing.Size(201, 20);
            this.modelInputField.TabIndex = 13;
            // 
            // vinInputField
            // 
            this.vinInputField.Location = new System.Drawing.Point(257, 18);
            this.vinInputField.Name = "vinInputField";
            this.vinInputField.Size = new System.Drawing.Size(201, 20);
            this.vinInputField.TabIndex = 14;
            // 
            // busNumberInputField
            // 
            this.busNumberInputField.Location = new System.Drawing.Point(257, 150);
            this.busNumberInputField.Name = "busNumberInputField";
            this.busNumberInputField.Size = new System.Drawing.Size(201, 20);
            this.busNumberInputField.TabIndex = 15;
            // 
            // garageNumberInputField
            // 
            this.garageNumberInputField.Location = new System.Drawing.Point(257, 176);
            this.garageNumberInputField.Name = "garageNumberInputField";
            this.garageNumberInputField.Size = new System.Drawing.Size(201, 20);
            this.garageNumberInputField.TabIndex = 16;
            // 
            // tankVolumeInputField
            // 
            this.tankVolumeInputField.Location = new System.Drawing.Point(257, 228);
            this.tankVolumeInputField.Name = "tankVolumeInputField";
            this.tankVolumeInputField.Size = new System.Drawing.Size(201, 20);
            this.tankVolumeInputField.TabIndex = 17;
            // 
            // prodYearInputField
            // 
            this.prodYearInputField.Location = new System.Drawing.Point(257, 97);
            this.prodYearInputField.Name = "prodYearInputField";
            this.prodYearInputField.Size = new System.Drawing.Size(201, 20);
            this.prodYearInputField.TabIndex = 18;
            // 
            // mileageInputField
            // 
            this.mileageInputField.Location = new System.Drawing.Point(257, 202);
            this.mileageInputField.Name = "mileageInputField";
            this.mileageInputField.Size = new System.Drawing.Size(201, 20);
            this.mileageInputField.TabIndex = 19;
            // 
            // addBusButton
            // 
            this.addBusButton.Location = new System.Drawing.Point(158, 291);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(183, 23);
            this.addBusButton.TabIndex = 20;
            this.addBusButton.Text = "Добавить автобус";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 336);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.mileageInputField);
            this.Controls.Add(this.prodYearInputField);
            this.Controls.Add(this.tankVolumeInputField);
            this.Controls.Add(this.garageNumberInputField);
            this.Controls.Add(this.busNumberInputField);
            this.Controls.Add(this.vinInputField);
            this.Controls.Add(this.modelInputField);
            this.Controls.Add(this.licenseInputField);
            this.Controls.Add(this.companyInputField);
            this.Controls.Add(this.manufInputField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBus";
            this.Text = "Добавить автобус";
            this.Load += new System.EventHandler(this.AddBus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox manufInputField;
        private System.Windows.Forms.ComboBox companyInputField;
        private System.Windows.Forms.ComboBox licenseInputField;
        private System.Windows.Forms.TextBox modelInputField;
        private System.Windows.Forms.TextBox vinInputField;
        private System.Windows.Forms.TextBox busNumberInputField;
        private System.Windows.Forms.TextBox garageNumberInputField;
        private System.Windows.Forms.TextBox tankVolumeInputField;
        private System.Windows.Forms.TextBox prodYearInputField;
        private System.Windows.Forms.TextBox mileageInputField;
        private System.Windows.Forms.Button addBusButton;
    }
}