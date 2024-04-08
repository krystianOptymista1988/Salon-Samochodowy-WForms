namespace Salon_Samochodowy_WF
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbEngineCapacity = new System.Windows.Forms.TextBox();
            this.tbEnginePower = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbNrOfAxies = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbEngineCapacity = new System.Windows.Forms.Label();
            this.lbEnginePower = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbNrOfAxies = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbVinNumber = new System.Windows.Forms.Label();
            this.tbVinNumber = new System.Windows.Forms.TextBox();
            this.btSell = new System.Windows.Forms.Button();
            this.lbNoRegistration = new System.Windows.Forms.Label();
            this.tbNoRegistration = new System.Windows.Forms.TextBox();
            this.lbCarMileage = new System.Windows.Forms.Label();
            this.tbCarMileage = new System.Windows.Forms.TextBox();
            this.tbPriceOfSell = new System.Windows.Forms.TextBox();
            this.lbPriceOfSell = new System.Windows.Forms.Label();
            this.lbSellValue = new System.Windows.Forms.Label();
            this.lbSellValueView = new System.Windows.Forms.Label();
            this.chbNotSelled = new System.Windows.Forms.CheckBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btAddPhoto = new System.Windows.Forms.Button();
            this.btShowPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(304, 124);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(223, 26);
            this.tbWeight.TabIndex = 1;
            // 
            // tbEngineCapacity
            // 
            this.tbEngineCapacity.Location = new System.Drawing.Point(304, 175);
            this.tbEngineCapacity.Name = "tbEngineCapacity";
            this.tbEngineCapacity.Size = new System.Drawing.Size(223, 26);
            this.tbEngineCapacity.TabIndex = 2;
            // 
            // tbEnginePower
            // 
            this.tbEnginePower.Location = new System.Drawing.Point(690, 75);
            this.tbEnginePower.Name = "tbEnginePower";
            this.tbEnginePower.Size = new System.Drawing.Size(223, 26);
            this.tbEnginePower.TabIndex = 3;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(690, 124);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(223, 26);
            this.tbColor.TabIndex = 4;
            // 
            // tbNrOfAxies
            // 
            this.tbNrOfAxies.Location = new System.Drawing.Point(690, 175);
            this.tbNrOfAxies.Name = "tbNrOfAxies";
            this.tbNrOfAxies.Size = new System.Drawing.Size(223, 26);
            this.tbNrOfAxies.TabIndex = 5;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(210, 78);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(77, 20);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Kategoria";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(187, 127);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(111, 20);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "Waga pojazdu";
            // 
            // lbEngineCapacity
            // 
            this.lbEngineCapacity.AutoSize = true;
            this.lbEngineCapacity.Location = new System.Drawing.Point(205, 175);
            this.lbEngineCapacity.Name = "lbEngineCapacity";
            this.lbEngineCapacity.Size = new System.Drawing.Size(82, 20);
            this.lbEngineCapacity.TabIndex = 8;
            this.lbEngineCapacity.Text = "Poj. silnika";
            // 
            // lbEnginePower
            // 
            this.lbEnginePower.AutoSize = true;
            this.lbEnginePower.Location = new System.Drawing.Point(586, 78);
            this.lbEnginePower.Name = "lbEnginePower";
            this.lbEnginePower.Size = new System.Drawing.Size(92, 20);
            this.lbEnginePower.TabIndex = 9;
            this.lbEnginePower.Text = "Moc Silinika";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(623, 127);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(45, 20);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Kolor";
            // 
            // lbNrOfAxies
            // 
            this.lbNrOfAxies.AutoSize = true;
            this.lbNrOfAxies.Location = new System.Drawing.Point(611, 178);
            this.lbNrOfAxies.Name = "lbNrOfAxies";
            this.lbNrOfAxies.Size = new System.Drawing.Size(67, 20);
            this.lbNrOfAxies.TabIndex = 11;
            this.lbNrOfAxies.Text = "ilość Osi";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(660, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(854, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 40);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(1044, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCars
            // 
            this.dgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(60, 303);
            this.dgvCars.MinimumSize = new System.Drawing.Size(889, 542);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCars.RowHeadersVisible = false;
            this.dgvCars.RowHeadersWidth = 62;
            this.dgvCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCars.RowTemplate.Height = 28;
            this.dgvCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Size = new System.Drawing.Size(1408, 542);
            this.dgvCars.TabIndex = 20;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(71, 63);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(101, 26);
            this.tbId.TabIndex = 21;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(30, 63);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(23, 20);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "Id";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(221, 36);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(52, 20);
            this.lbModel.TabIndex = 23;
            this.lbModel.Text = "Model";
            // 
            // lbVinNumber
            // 
            this.lbVinNumber.AutoSize = true;
            this.lbVinNumber.Location = new System.Drawing.Point(611, 36);
            this.lbVinNumber.Name = "lbVinNumber";
            this.lbVinNumber.Size = new System.Drawing.Size(56, 20);
            this.lbVinNumber.TabIndex = 24;
            this.lbVinNumber.Text = "Nr. Vin";
            // 
            // tbVinNumber
            // 
            this.tbVinNumber.Location = new System.Drawing.Point(690, 30);
            this.tbVinNumber.Name = "tbVinNumber";
            this.tbVinNumber.Size = new System.Drawing.Size(223, 26);
            this.tbVinNumber.TabIndex = 26;
            // 
            // btSell
            // 
            this.btSell.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btSell.Location = new System.Drawing.Point(1231, 227);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(237, 61);
            this.btSell.TabIndex = 27;
            this.btSell.Text = "Sprzedaj";
            this.btSell.UseVisualStyleBackColor = false;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // lbNoRegistration
            // 
            this.lbNoRegistration.AutoSize = true;
            this.lbNoRegistration.Location = new System.Drawing.Point(968, 33);
            this.lbNoRegistration.Name = "lbNoRegistration";
            this.lbNoRegistration.Size = new System.Drawing.Size(127, 20);
            this.lbNoRegistration.TabIndex = 28;
            this.lbNoRegistration.Text = "Nr. Rejestracyjny";
            // 
            // tbNoRegistration
            // 
            this.tbNoRegistration.Location = new System.Drawing.Point(1101, 30);
            this.tbNoRegistration.Name = "tbNoRegistration";
            this.tbNoRegistration.Size = new System.Drawing.Size(223, 26);
            this.tbNoRegistration.TabIndex = 29;
            // 
            // lbCarMileage
            // 
            this.lbCarMileage.AutoSize = true;
            this.lbCarMileage.Location = new System.Drawing.Point(1024, 75);
            this.lbCarMileage.Name = "lbCarMileage";
            this.lbCarMileage.Size = new System.Drawing.Size(71, 20);
            this.lbCarMileage.TabIndex = 30;
            this.lbCarMileage.Text = "Przebieg";
            // 
            // tbCarMileage
            // 
            this.tbCarMileage.Location = new System.Drawing.Point(1101, 72);
            this.tbCarMileage.Name = "tbCarMileage";
            this.tbCarMileage.Size = new System.Drawing.Size(223, 26);
            this.tbCarMileage.TabIndex = 31;
            // 
            // tbPriceOfSell
            // 
            this.tbPriceOfSell.Location = new System.Drawing.Point(1101, 124);
            this.tbPriceOfSell.Name = "tbPriceOfSell";
            this.tbPriceOfSell.Size = new System.Drawing.Size(223, 26);
            this.tbPriceOfSell.TabIndex = 32;
            // 
            // lbPriceOfSell
            // 
            this.lbPriceOfSell.AutoSize = true;
            this.lbPriceOfSell.Location = new System.Drawing.Point(968, 127);
            this.lbPriceOfSell.Name = "lbPriceOfSell";
            this.lbPriceOfSell.Size = new System.Drawing.Size(126, 20);
            this.lbPriceOfSell.TabIndex = 34;
            this.lbPriceOfSell.Text = "Cena Sprzedaży";
            // 
            // lbSellValue
            // 
            this.lbSellValue.AutoSize = true;
            this.lbSellValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lbSellValue.Location = new System.Drawing.Point(965, 178);
            this.lbSellValue.Name = "lbSellValue";
            this.lbSellValue.Size = new System.Drawing.Size(270, 20);
            this.lbSellValue.TabIndex = 35;
            this.lbSellValue.Text = "Wartość Sprzedanych Samochodów:";
            // 
            // lbSellValueView
            // 
            this.lbSellValueView.AutoSize = true;
            this.lbSellValueView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSellValueView.ForeColor = System.Drawing.Color.DarkRed;
            this.lbSellValueView.Location = new System.Drawing.Point(1241, 178);
            this.lbSellValueView.Name = "lbSellValueView";
            this.lbSellValueView.Size = new System.Drawing.Size(69, 22);
            this.lbSellValueView.TabIndex = 36;
            this.lbSellValueView.Text = "0,00 zł";
            // 
            // chbNotSelled
            // 
            this.chbNotSelled.AutoSize = true;
            this.chbNotSelled.Location = new System.Drawing.Point(378, 259);
            this.chbNotSelled.Name = "chbNotSelled";
            this.chbNotSelled.Size = new System.Drawing.Size(256, 24);
            this.chbNotSelled.TabIndex = 37;
            this.chbNotSelled.Text = "Pokazuj tylko dostępne pojazdy";
            this.chbNotSelled.UseVisualStyleBackColor = true;
            this.chbNotSelled.CheckedChanged += new System.EventHandler(this.chbNotSelled_CheckedChanged);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(304, 33);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(223, 26);
            this.tbModel.TabIndex = 25;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(304, 78);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(223, 28);
            this.cbCategory.TabIndex = 38;
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(67, 260);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(51, 20);
            this.lbSort.TabIndex = 39;
            this.lbSort.Text = "Sortuj";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(124, 257);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(223, 28);
            this.cbSort.TabIndex = 40;
            this.cbSort.SelectedValueChanged += new System.EventHandler(this.cbSort_SelectedValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btAddPhoto
            // 
            this.btAddPhoto.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btAddPhoto.Location = new System.Drawing.Point(1369, 29);
            this.btAddPhoto.Name = "btAddPhoto";
            this.btAddPhoto.Size = new System.Drawing.Size(142, 69);
            this.btAddPhoto.TabIndex = 41;
            this.btAddPhoto.Text = "Dodaj zdjęcie";
            this.btAddPhoto.UseVisualStyleBackColor = false;
            this.btAddPhoto.Click += new System.EventHandler(this.btAddPhoto_Click);
            // 
            // btShowPicture
            // 
            this.btShowPicture.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btShowPicture.Location = new System.Drawing.Point(1369, 124);
            this.btShowPicture.Name = "btShowPicture";
            this.btShowPicture.Size = new System.Drawing.Size(142, 69);
            this.btShowPicture.TabIndex = 42;
            this.btShowPicture.Text = "Pokaż zdjęcie";
            this.btShowPicture.UseVisualStyleBackColor = false;
            this.btShowPicture.Click += new System.EventHandler(this.btShowPicture_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1523, 879);
            this.Controls.Add(this.btShowPicture);
            this.Controls.Add(this.btAddPhoto);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lbSort);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.chbNotSelled);
            this.Controls.Add(this.lbSellValueView);
            this.Controls.Add(this.lbSellValue);
            this.Controls.Add(this.lbPriceOfSell);
            this.Controls.Add(this.tbPriceOfSell);
            this.Controls.Add(this.tbCarMileage);
            this.Controls.Add(this.lbCarMileage);
            this.Controls.Add(this.tbNoRegistration);
            this.Controls.Add(this.lbNoRegistration);
            this.Controls.Add(this.btSell);
            this.Controls.Add(this.tbVinNumber);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.lbVinNumber);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgvCars);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbNrOfAxies);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbEnginePower);
            this.Controls.Add(this.lbEngineCapacity);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.tbNrOfAxies);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbEnginePower);
            this.Controls.Add(this.tbEngineCapacity);
            this.Controls.Add(this.tbWeight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Salon Samochodowy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbEngineCapacity;
        private System.Windows.Forms.TextBox tbEnginePower;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbNrOfAxies;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbEngineCapacity;
        private System.Windows.Forms.Label lbEnginePower;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbNrOfAxies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbVinNumber;
        private System.Windows.Forms.TextBox tbVinNumber;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.Label lbNoRegistration;
        private System.Windows.Forms.TextBox tbNoRegistration;
        private System.Windows.Forms.Label lbCarMileage;
        private System.Windows.Forms.TextBox tbCarMileage;
        private System.Windows.Forms.TextBox tbPriceOfSell;
        private System.Windows.Forms.Label lbPriceOfSell;
        private System.Windows.Forms.Label lbSellValue;
        private System.Windows.Forms.Label lbSellValueView;
        private System.Windows.Forms.CheckBox chbNotSelled;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbSort;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btAddPhoto;
        private System.Windows.Forms.Button btShowPicture;
    }
}

