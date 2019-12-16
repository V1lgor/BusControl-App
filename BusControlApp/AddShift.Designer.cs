namespace BusControlApp
{
    partial class AddShift
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
            this.label2 = new System.Windows.Forms.Label();
            this.scheduleInputField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.busInputField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.driverInputField = new System.Windows.Forms.ComboBox();
            this.addShiftAcceptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите маршрут:";
            // 
            // routeInputField
            // 
            this.routeInputField.FormattingEnabled = true;
            this.routeInputField.Location = new System.Drawing.Point(43, 57);
            this.routeInputField.Name = "routeInputField";
            this.routeInputField.Size = new System.Drawing.Size(121, 21);
            this.routeInputField.TabIndex = 1;
            this.routeInputField.SelectedValueChanged += new System.EventHandler(this.RouteInputField_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите график маршрута:";
            // 
            // scheduleInputField
            // 
            this.scheduleInputField.FormattingEnabled = true;
            this.scheduleInputField.Location = new System.Drawing.Point(43, 124);
            this.scheduleInputField.Name = "scheduleInputField";
            this.scheduleInputField.Size = new System.Drawing.Size(121, 21);
            this.scheduleInputField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберите автобус:";
            // 
            // busInputField
            // 
            this.busInputField.FormattingEnabled = true;
            this.busInputField.Location = new System.Drawing.Point(225, 57);
            this.busInputField.Name = "busInputField";
            this.busInputField.Size = new System.Drawing.Size(175, 21);
            this.busInputField.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите водителя:";
            // 
            // driverInputField
            // 
            this.driverInputField.FormattingEnabled = true;
            this.driverInputField.Location = new System.Drawing.Point(225, 124);
            this.driverInputField.Name = "driverInputField";
            this.driverInputField.Size = new System.Drawing.Size(175, 21);
            this.driverInputField.TabIndex = 7;
            // 
            // addShiftAcceptBtn
            // 
            this.addShiftAcceptBtn.Location = new System.Drawing.Point(150, 174);
            this.addShiftAcceptBtn.Name = "addShiftAcceptBtn";
            this.addShiftAcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.addShiftAcceptBtn.TabIndex = 8;
            this.addShiftAcceptBtn.Text = "Принять";
            this.addShiftAcceptBtn.UseVisualStyleBackColor = true;
            // 
            // AddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 237);
            this.Controls.Add(this.addShiftAcceptBtn);
            this.Controls.Add(this.driverInputField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.busInputField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scheduleInputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.routeInputField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddShift";
            this.ShowIcon = false;
            this.Text = "Добавление смены";
            this.Load += new System.EventHandler(this.AddShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox routeInputField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scheduleInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox busInputField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox driverInputField;
        private System.Windows.Forms.Button addShiftAcceptBtn;
    }
}