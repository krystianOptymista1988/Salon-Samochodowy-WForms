﻿namespace Salon_Samochodowy_WF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbCategory = new System.Windows.Forms.TextBox();
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
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(292, 31);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(223, 26);
            this.tbCategory.TabIndex = 0;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(292, 83);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(223, 26);
            this.tbWeight.TabIndex = 1;
            // 
            // tbEngineCapacity
            // 
            this.tbEngineCapacity.Location = new System.Drawing.Point(292, 143);
            this.tbEngineCapacity.Name = "tbEngineCapacity";
            this.tbEngineCapacity.Size = new System.Drawing.Size(223, 26);
            this.tbEngineCapacity.TabIndex = 2;
            // 
            // tbEnginePower
            // 
            this.tbEnginePower.Location = new System.Drawing.Point(678, 31);
            this.tbEnginePower.Name = "tbEnginePower";
            this.tbEnginePower.Size = new System.Drawing.Size(223, 26);
            this.tbEnginePower.TabIndex = 3;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(678, 83);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(223, 26);
            this.tbColor.TabIndex = 4;
            // 
            // tbNrOfAxies
            // 
            this.tbNrOfAxies.Location = new System.Drawing.Point(678, 143);
            this.tbNrOfAxies.Name = "tbNrOfAxies";
            this.tbNrOfAxies.Size = new System.Drawing.Size(223, 26);
            this.tbNrOfAxies.TabIndex = 5;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(193, 34);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(77, 20);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Kategoria";
            this.lbCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(175, 83);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(111, 20);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "Waga pojazdu";
            // 
            // lbEngineCapacity
            // 
            this.lbEngineCapacity.AutoSize = true;
            this.lbEngineCapacity.Location = new System.Drawing.Point(193, 143);
            this.lbEngineCapacity.Name = "lbEngineCapacity";
            this.lbEngineCapacity.Size = new System.Drawing.Size(82, 20);
            this.lbEngineCapacity.TabIndex = 8;
            this.lbEngineCapacity.Text = "Poj. silnika";
            // 
            // lbEnginePower
            // 
            this.lbEnginePower.AutoSize = true;
            this.lbEnginePower.Location = new System.Drawing.Point(580, 37);
            this.lbEnginePower.Name = "lbEnginePower";
            this.lbEnginePower.Size = new System.Drawing.Size(92, 20);
            this.lbEnginePower.TabIndex = 9;
            this.lbEnginePower.Text = "Moc Silinika";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(621, 89);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(45, 20);
            this.lbColor.TabIndex = 10;
            this.lbColor.Text = "Kolor";
            // 
            // lbNrOfAxies
            // 
            this.lbNrOfAxies.AutoSize = true;
            this.lbNrOfAxies.Location = new System.Drawing.Point(599, 146);
            this.lbNrOfAxies.Name = "lbNrOfAxies";
            this.lbNrOfAxies.Size = new System.Drawing.Size(67, 20);
            this.lbNrOfAxies.TabIndex = 11;
            this.lbNrOfAxies.Text = "ilość Osi";
            // 
            // dgvCars
            // 
            this.dgvCars.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(99, 277);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 62;
            this.dgvCars.RowTemplate.Height = 28;
            this.dgvCars.Size = new System.Drawing.Size(917, 524);
            this.dgvCars.TabIndex = 12;
            this.dgvCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(362, 220);
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
            this.btnEdit.Location = new System.Drawing.Point(627, 220);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 40);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(881, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(99, 220);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 40);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Klasa Vehicle";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1102, 879);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvCars);
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
            this.Controls.Add(this.tbCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Salon Samochodowy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCategory;
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
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}

