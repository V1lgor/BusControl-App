namespace BusControlApp
{
    partial class SelectActionPage
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
            this.welcomeText = new System.Windows.Forms.Label();
            this.showBusesBtn = new System.Windows.Forms.Button();
            this.showShiftTableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Location = new System.Drawing.Point(13, 13);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(174, 13);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Выберите необходимую таблицу:";
            // 
            // showBusesBtn
            // 
            this.showBusesBtn.Location = new System.Drawing.Point(16, 44);
            this.showBusesBtn.Name = "showBusesBtn";
            this.showBusesBtn.Size = new System.Drawing.Size(168, 23);
            this.showBusesBtn.TabIndex = 1;
            this.showBusesBtn.Text = "Автобусы";
            this.showBusesBtn.UseVisualStyleBackColor = true;
            this.showBusesBtn.Click += new System.EventHandler(this.showBusesBtn_Click);
            // 
            // showShiftTableBtn
            // 
            this.showShiftTableBtn.Location = new System.Drawing.Point(16, 92);
            this.showShiftTableBtn.Name = "showShiftTableBtn";
            this.showShiftTableBtn.Size = new System.Drawing.Size(168, 23);
            this.showShiftTableBtn.TabIndex = 2;
            this.showShiftTableBtn.Text = "Смены";
            this.showShiftTableBtn.UseVisualStyleBackColor = true;
            this.showShiftTableBtn.Click += new System.EventHandler(this.ShowShiftTableBtn_Click);
            // 
            // SelectActionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 153);
            this.ControlBox = false;
            this.Controls.Add(this.showShiftTableBtn);
            this.Controls.Add(this.showBusesBtn);
            this.Controls.Add(this.welcomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectActionPage";
            this.Text = "SelectActionPage";
            this.Load += new System.EventHandler(this.SelectActionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button showBusesBtn;
        private System.Windows.Forms.Button showShiftTableBtn;
    }
}