namespace BusControlApp
{
    partial class UpdateShift
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
            this.routeInputField = new System.Windows.Forms.ComboBox();
            this.driverInputField = new System.Windows.Forms.ComboBox();
            this.scheduleInputField = new System.Windows.Forms.ComboBox();
            this.busInputField = new System.Windows.Forms.ComboBox();
            this.linearControlInputField = new System.Windows.Forms.TextBox();
            this.layUpInfo = new System.Windows.Forms.TextBox();
            this.startFuelInputField = new System.Windows.Forms.TextBox();
            this.endFuelInputField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveUpdatedShiftButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.shiftEarningsInputField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите маршрут:";
            // 
            // routeInputField
            // 
            this.routeInputField.FormattingEnabled = true;
            this.routeInputField.Location = new System.Drawing.Point(180, 21);
            this.routeInputField.Name = "routeInputField";
            this.routeInputField.Size = new System.Drawing.Size(121, 21);
            this.routeInputField.TabIndex = 1;
            this.routeInputField.SelectedValueChanged += new System.EventHandler(this.RouteInputField_SelectedValueChanged);
            // 
            // driverInputField
            // 
            this.driverInputField.FormattingEnabled = true;
            this.driverInputField.Location = new System.Drawing.Point(180, 85);
            this.driverInputField.Name = "driverInputField";
            this.driverInputField.Size = new System.Drawing.Size(121, 21);
            this.driverInputField.TabIndex = 2;
            // 
            // scheduleInputField
            // 
            this.scheduleInputField.FormattingEnabled = true;
            this.scheduleInputField.Location = new System.Drawing.Point(180, 53);
            this.scheduleInputField.Name = "scheduleInputField";
            this.scheduleInputField.Size = new System.Drawing.Size(121, 21);
            this.scheduleInputField.TabIndex = 3;
            // 
            // busInputField
            // 
            this.busInputField.FormattingEnabled = true;
            this.busInputField.Location = new System.Drawing.Point(180, 115);
            this.busInputField.Name = "busInputField";
            this.busInputField.Size = new System.Drawing.Size(121, 21);
            this.busInputField.TabIndex = 4;
            // 
            // linearControlInputField
            // 
            this.linearControlInputField.Location = new System.Drawing.Point(180, 195);
            this.linearControlInputField.Multiline = true;
            this.linearControlInputField.Name = "linearControlInputField";
            this.linearControlInputField.Size = new System.Drawing.Size(121, 51);
            this.linearControlInputField.TabIndex = 5;
            // 
            // layUpInfo
            // 
            this.layUpInfo.Location = new System.Drawing.Point(180, 265);
            this.layUpInfo.Multiline = true;
            this.layUpInfo.Name = "layUpInfo";
            this.layUpInfo.Size = new System.Drawing.Size(121, 54);
            this.layUpInfo.TabIndex = 6;
            // 
            // startFuelInputField
            // 
            this.startFuelInputField.Location = new System.Drawing.Point(180, 325);
            this.startFuelInputField.Name = "startFuelInputField";
            this.startFuelInputField.Size = new System.Drawing.Size(121, 20);
            this.startFuelInputField.TabIndex = 7;
            // 
            // endFuelInputField
            // 
            this.endFuelInputField.Location = new System.Drawing.Point(180, 355);
            this.endFuelInputField.Name = "endFuelInputField";
            this.endFuelInputField.Size = new System.Drawing.Size(121, 20);
            this.endFuelInputField.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите график:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Топливо до начала смены";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выберите водителя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Топливо в конце смены";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Линейный контроль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Выберите автобус:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Информация о простоях";
            // 
            // saveUpdatedShiftButton
            // 
            this.saveUpdatedShiftButton.Location = new System.Drawing.Point(126, 394);
            this.saveUpdatedShiftButton.Name = "saveUpdatedShiftButton";
            this.saveUpdatedShiftButton.Size = new System.Drawing.Size(75, 23);
            this.saveUpdatedShiftButton.TabIndex = 19;
            this.saveUpdatedShiftButton.Text = "Сохранить";
            this.saveUpdatedShiftButton.UseVisualStyleBackColor = true;
            this.saveUpdatedShiftButton.Click += new System.EventHandler(this.SaveUpdatedShiftButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выручка за смену:";
            // 
            // shiftEarningsInputField
            // 
            this.shiftEarningsInputField.Location = new System.Drawing.Point(180, 155);
            this.shiftEarningsInputField.Name = "shiftEarningsInputField";
            this.shiftEarningsInputField.Size = new System.Drawing.Size(121, 20);
            this.shiftEarningsInputField.TabIndex = 21;
            // 
            // UpdateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.shiftEarningsInputField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveUpdatedShiftButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endFuelInputField);
            this.Controls.Add(this.startFuelInputField);
            this.Controls.Add(this.layUpInfo);
            this.Controls.Add(this.linearControlInputField);
            this.Controls.Add(this.busInputField);
            this.Controls.Add(this.scheduleInputField);
            this.Controls.Add(this.driverInputField);
            this.Controls.Add(this.routeInputField);
            this.Controls.Add(this.label1);
            this.Name = "UpdateShift";
            this.Text = "UpdateShift";
            this.Load += new System.EventHandler(this.UpdateShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox routeInputField;
        private System.Windows.Forms.ComboBox driverInputField;
        private System.Windows.Forms.ComboBox scheduleInputField;
        private System.Windows.Forms.ComboBox busInputField;
        private System.Windows.Forms.TextBox linearControlInputField;
        private System.Windows.Forms.TextBox layUpInfo;
        private System.Windows.Forms.TextBox startFuelInputField;
        private System.Windows.Forms.TextBox endFuelInputField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveUpdatedShiftButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shiftEarningsInputField;
    }
}