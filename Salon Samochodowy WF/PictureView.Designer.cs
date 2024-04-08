namespace Salon_Samochodowy_WF
{
    partial class PictureView
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
            this.pbCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(3, -1);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(1544, 998);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCar.TabIndex = 0;
            this.pbCar.TabStop = false;
            // 
            // PictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1559, 1037);
            this.Controls.Add(this.pbCar);
            this.Name = "PictureView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCar;
    }
}