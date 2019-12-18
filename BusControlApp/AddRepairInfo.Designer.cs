namespace BusControlApp
{
    partial class AddRepairInfo
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
            this.repairCostInputField = new System.Windows.Forms.TextBox();
            this.repairInfoInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mechInputField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcceptRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repairCostInputField
            // 
            this.repairCostInputField.Location = new System.Drawing.Point(18, 46);
            this.repairCostInputField.Name = "repairCostInputField";
            this.repairCostInputField.Size = new System.Drawing.Size(152, 20);
            this.repairCostInputField.TabIndex = 0;
            // 
            // repairInfoInputField
            // 
            this.repairInfoInputField.Location = new System.Drawing.Point(18, 134);
            this.repairInfoInputField.Multiline = true;
            this.repairInfoInputField.Name = "repairInfoInputField";
            this.repairInfoInputField.Size = new System.Drawing.Size(343, 118);
            this.repairInfoInputField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите стоимость ремонта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите информацию о ремонте:";
            // 
            // mechInputField
            // 
            this.mechInputField.FormattingEnabled = true;
            this.mechInputField.Location = new System.Drawing.Point(18, 305);
            this.mechInputField.Name = "mechInputField";
            this.mechInputField.Size = new System.Drawing.Size(192, 21);
            this.mechInputField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите ответственного механика:";
            // 
            // btnAcceptRepair
            // 
            this.btnAcceptRepair.Location = new System.Drawing.Point(112, 362);
            this.btnAcceptRepair.Name = "btnAcceptRepair";
            this.btnAcceptRepair.Size = new System.Drawing.Size(171, 23);
            this.btnAcceptRepair.TabIndex = 6;
            this.btnAcceptRepair.Text = "Добавить";
            this.btnAcceptRepair.UseVisualStyleBackColor = true;
            this.btnAcceptRepair.Click += new System.EventHandler(this.btnAcceptRepair_Click);
            // 
            // AddRepairInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 417);
            this.Controls.Add(this.btnAcceptRepair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mechInputField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repairInfoInputField);
            this.Controls.Add(this.repairCostInputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddRepairInfo";
            this.Text = "Добавить информацию о ремонте";
            this.Load += new System.EventHandler(this.AddRepairInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repairCostInputField;
        private System.Windows.Forms.TextBox repairInfoInputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mechInputField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcceptRepair;
    }
}