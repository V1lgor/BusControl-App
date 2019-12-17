namespace BusControlApp
{
    partial class ShiftPage
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
            this.shiftTable = new System.Windows.Forms.DataGridView();
            this.shiftId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftScheduleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftBusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftEarnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addShiftBtn = new System.Windows.Forms.Button();
            this.updateShiftButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTable)).BeginInit();
            this.SuspendLayout();
            // 
            // shiftTable
            // 
            this.shiftTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shiftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftId,
            this.shiftDate,
            this.shiftRoute,
            this.shiftScheduleNumber,
            this.shiftBusNumber,
            this.shiftEarnings,
            this.shiftDriver});
            this.shiftTable.Location = new System.Drawing.Point(57, 36);
            this.shiftTable.Name = "shiftTable";
            this.shiftTable.Size = new System.Drawing.Size(744, 279);
            this.shiftTable.TabIndex = 0;
            this.shiftTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShiftTable_CellClick);
            
            // shiftId
            // 
            this.shiftId.HeaderText = "ID";
            this.shiftId.Name = "shiftId";
            // 
            // shiftDate
            // 
            this.shiftDate.HeaderText = "Дата";
            this.shiftDate.Name = "shiftDate";
            // 
            // shiftRoute
            // 
            this.shiftRoute.HeaderText = "Маршрут";
            this.shiftRoute.Name = "shiftRoute";
            // 
            // shiftScheduleNumber
            // 
            this.shiftScheduleNumber.HeaderText = "График";
            this.shiftScheduleNumber.Name = "shiftScheduleNumber";
            // 
            // shiftBusNumber
            // 
            this.shiftBusNumber.HeaderText = "Автобус";
            this.shiftBusNumber.Name = "shiftBusNumber";
            // 
            // shiftEarnings
            // 
            this.shiftEarnings.HeaderText = "Выручка";
            this.shiftEarnings.Name = "shiftEarnings";
            // 
            // shiftDriver
            // 
            this.shiftDriver.HeaderText = "Водитель";
            this.shiftDriver.Name = "shiftDriver";
            // 
            // addShiftBtn
            // 
            this.addShiftBtn.Location = new System.Drawing.Point(57, 338);
            this.addShiftBtn.Name = "addShiftBtn";
            this.addShiftBtn.Size = new System.Drawing.Size(112, 23);
            this.addShiftBtn.TabIndex = 1;
            this.addShiftBtn.Text = "Добавить смену";
            this.addShiftBtn.UseVisualStyleBackColor = true;
            this.addShiftBtn.Click += new System.EventHandler(this.AddShiftBtn_Click);
            // 
            // updateShiftButton
            // 
            this.updateShiftButton.Enabled = false;
            this.updateShiftButton.Location = new System.Drawing.Point(204, 338);
            this.updateShiftButton.Name = "updateShiftButton";
            this.updateShiftButton.Size = new System.Drawing.Size(113, 23);
            this.updateShiftButton.TabIndex = 2;
            this.updateShiftButton.Text = "Обновить смену";
            this.updateShiftButton.UseVisualStyleBackColor = true;
            this.updateShiftButton.Click += new System.EventHandler(this.UpdateShiftButton_Click);
            // 
            // ShiftPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 381);
            this.Controls.Add(this.updateShiftButton);
            this.Controls.Add(this.addShiftBtn);
            this.Controls.Add(this.shiftTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftPage";
            this.Text = "ShiftPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftPage_FormClosed);
            this.Load += new System.EventHandler(this.ShiftPage_Load);
            this.Resize += new System.EventHandler(this.ShiftPage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.shiftTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shiftTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftScheduleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftBusNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftEarnings;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDriver;
        private System.Windows.Forms.Button addShiftBtn;
        private System.Windows.Forms.Button updateShiftButton;
    }
}