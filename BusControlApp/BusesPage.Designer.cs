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
            this.addBusBtn = new System.Windows.Forms.Button();
            this.searchBusText = new System.Windows.Forms.Label();
            this.busNumberSearchField = new System.Windows.Forms.TextBox();
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
            // addBusBtn
            // 
            this.addBusBtn.Location = new System.Drawing.Point(54, 522);
            this.addBusBtn.Name = "addBusBtn";
            this.addBusBtn.Size = new System.Drawing.Size(176, 41);
            this.addBusBtn.TabIndex = 1;
            this.addBusBtn.Text = "Добавить автобус";
            this.addBusBtn.UseVisualStyleBackColor = true;
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
            // BusesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 613);
            this.ControlBox = false;
            this.Controls.Add(this.busNumberSearchField);
            this.Controls.Add(this.searchBusText);
            this.Controls.Add(this.addBusBtn);
            this.Controls.Add(this.busesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusesPage";
            this.Text = "BusesPage";
            this.Load += new System.EventHandler(this.BusesPage_Load);
            this.Resize += new System.EventHandler(this.BusesPage_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.busesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView busesTable;
        private System.Windows.Forms.Button addBusBtn;
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
    }
}