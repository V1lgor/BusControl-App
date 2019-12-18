namespace BusControlApp
{
    partial class BusesPage
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
            this.busesTable = new System.Windows.Forms.DataGridView();
            this.busId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busVIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busProductionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busGarageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busLicenseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTankVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busIsWrittenOff = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addBusButton = new System.Windows.Forms.Button();
            this.searchBusText = new System.Windows.Forms.Label();
            this.busNumberSearchField = new System.Windows.Forms.TextBox();
            this.updateBusButton = new System.Windows.Forms.Button();
            this.writeOffBusButton = new System.Windows.Forms.Button();
            this.addRepairButton = new System.Windows.Forms.Button();
            this.showBusRepairsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.busesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // busesTable
            // 
            this.busesTable.AllowUserToAddRows = false;
            this.busesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.busId,
            this.busNumber,
            this.busManufacturer,
            this.busModel,
            this.busVIN,
            this.busProductionYear,
            this.busCompany,
            this.busGarageNumber,
            this.busMileage,
            this.busLicenseCategory,
            this.busTankVolume,
            this.busIsWrittenOff});
            this.busesTable.Location = new System.Drawing.Point(54, 84);
            this.busesTable.Name = "busesTable";
            this.busesTable.Size = new System.Drawing.Size(1130, 400);
            this.busesTable.TabIndex = 0;
            this.busesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busesTable_CellClick);
            // 
            // busId
            // 
            this.busId.HeaderText = "ID";
            this.busId.Name = "busId";
            // 
            // busNumber
            // 
            this.busNumber.HeaderText = "Гос. номер";
            this.busNumber.Name = "busNumber";
            // 
            // busManufacturer
            // 
            this.busManufacturer.HeaderText = "Производитель";
            this.busManufacturer.Name = "busManufacturer";
            // 
            // busModel
            // 
            this.busModel.HeaderText = "Модель";
            this.busModel.Name = "busModel";
            // 
            // busVIN
            // 
            this.busVIN.HeaderText = "VIN ";
            this.busVIN.Name = "busVIN";
            // 
            // busProductionYear
            // 
            this.busProductionYear.HeaderText = "Год выпуска";
            this.busProductionYear.Name = "busProductionYear";
            // 
            // busCompany
            // 
            this.busCompany.HeaderText = "Перевозчик";
            this.busCompany.Name = "busCompany";
            // 
            // busGarageNumber
            // 
            this.busGarageNumber.HeaderText = "Гаражный номер";
            this.busGarageNumber.Name = "busGarageNumber";
            // 
            // busMileage
            // 
            this.busMileage.HeaderText = "Пробег";
            this.busMileage.Name = "busMileage";
            // 
            // busLicenseCategory
            // 
            this.busLicenseCategory.HeaderText = "Требуемая категория прав";
            this.busLicenseCategory.Name = "busLicenseCategory";
            // 
            // busTankVolume
            // 
            this.busTankVolume.HeaderText = "Объем бака";
            this.busTankVolume.Name = "busTankVolume";
            // 
            // busIsWrittenOff
            // 
            this.busIsWrittenOff.HeaderText = "Списан";
            this.busIsWrittenOff.Name = "busIsWrittenOff";
            this.busIsWrittenOff.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.busIsWrittenOff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addBusButton
            // 
            this.addBusButton.Location = new System.Drawing.Point(54, 522);
            this.addBusButton.Name = "addBusButton";
            this.addBusButton.Size = new System.Drawing.Size(176, 41);
            this.addBusButton.TabIndex = 1;
            this.addBusButton.Text = "Добавить автобус";
            this.addBusButton.UseVisualStyleBackColor = true;
            this.addBusButton.Click += new System.EventHandler(this.addBusButton_Click);
            // 
            // searchBusText
            // 
            this.searchBusText.AutoSize = true;
            this.searchBusText.Location = new System.Drawing.Point(51, 38);
            this.searchBusText.Name = "searchBusText";
            this.searchBusText.Size = new System.Drawing.Size(169, 13);
            this.searchBusText.TabIndex = 2;
            this.searchBusText.Text = "Поиск автобуса по гос. номеру:";
            // 
            // busNumberSearchField
            // 
            this.busNumberSearchField.Location = new System.Drawing.Point(229, 35);
            this.busNumberSearchField.Name = "busNumberSearchField";
            this.busNumberSearchField.Size = new System.Drawing.Size(86, 20);
            this.busNumberSearchField.TabIndex = 3;
            this.busNumberSearchField.TextChanged += new System.EventHandler(this.busNumberSearchField_TextChanged);
            // 
            // updateBusButton
            // 
            this.updateBusButton.Location = new System.Drawing.Point(239, 522);
            this.updateBusButton.Name = "updateBusButton";
            this.updateBusButton.Size = new System.Drawing.Size(178, 41);
            this.updateBusButton.TabIndex = 4;
            this.updateBusButton.Text = "Отредактировать автобус";
            this.updateBusButton.UseVisualStyleBackColor = true;
            this.updateBusButton.Click += new System.EventHandler(this.updateBusButton_Click);
            // 
            // writeOffBusButton
            // 
            this.writeOffBusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.writeOffBusButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.writeOffBusButton.Location = new System.Drawing.Point(994, 522);
            this.writeOffBusButton.Name = "writeOffBusButton";
            this.writeOffBusButton.Size = new System.Drawing.Size(190, 41);
            this.writeOffBusButton.TabIndex = 5;
            this.writeOffBusButton.Text = "Списать автобус";
            this.writeOffBusButton.UseVisualStyleBackColor = false;
            this.writeOffBusButton.Click += new System.EventHandler(this.writeOffBusButton_Click);
            // 
            // addRepairButton
            // 
            this.addRepairButton.Location = new System.Drawing.Point(438, 522);
            this.addRepairButton.Name = "addRepairButton";
            this.addRepairButton.Size = new System.Drawing.Size(178, 41);
            this.addRepairButton.TabIndex = 6;
            this.addRepairButton.Text = "Добавить информацию о ремонте";
            this.addRepairButton.UseVisualStyleBackColor = true;
            this.addRepairButton.Click += new System.EventHandler(this.addRepairButton_Click);
            // 
            // showBusRepairsButton
            // 
            this.showBusRepairsButton.Location = new System.Drawing.Point(634, 522);
            this.showBusRepairsButton.Name = "showBusRepairsButton";
            this.showBusRepairsButton.Size = new System.Drawing.Size(188, 41);
            this.showBusRepairsButton.TabIndex = 7;
            this.showBusRepairsButton.Text = "Просмотреть информацию о ремонтах";
            this.showBusRepairsButton.UseVisualStyleBackColor = true;
            // 
            // BusesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 613);
            this.ControlBox = false;
            this.Controls.Add(this.showBusRepairsButton);
            this.Controls.Add(this.addRepairButton);
            this.Controls.Add(this.writeOffBusButton);
            this.Controls.Add(this.updateBusButton);
            this.Controls.Add(this.busNumberSearchField);
            this.Controls.Add(this.searchBusText);
            this.Controls.Add(this.addBusButton);
            this.Controls.Add(this.busesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusesPage";
            this.Text = "BusesPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BusesPage_FormClosed);
            this.Load += new System.EventHandler(this.BusesPage_Load);
            this.Resize += new System.EventHandler(this.BusesPage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.busesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView busesTable;
        private System.Windows.Forms.Button addBusButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn busId;
        private System.Windows.Forms.DataGridViewTextBoxColumn busNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn busManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn busModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn busVIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn busProductionYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn busCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn busGarageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn busMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn busLicenseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTankVolume;
        private System.Windows.Forms.DataGridViewCheckBoxColumn busIsWrittenOff;
        private System.Windows.Forms.Label searchBusText;
        private System.Windows.Forms.TextBox busNumberSearchField;
        private System.Windows.Forms.Button updateBusButton;
        private System.Windows.Forms.Button writeOffBusButton;
        private System.Windows.Forms.Button addRepairButton;
        private System.Windows.Forms.Button showBusRepairsButton;
    }
}