namespace MüşteriTakipProgramı
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Lbl_TumMusteriler = new System.Windows.Forms.Label();
            this.DataGridV_TumMusteriler = new System.Windows.Forms.DataGridView();
            this.Btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridV_TumMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_TumMusteriler
            // 
            this.Lbl_TumMusteriler.AutoSize = true;
            this.Lbl_TumMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_TumMusteriler.Location = new System.Drawing.Point(24, 21);
            this.Lbl_TumMusteriler.Name = "Lbl_TumMusteriler";
            this.Lbl_TumMusteriler.Size = new System.Drawing.Size(90, 15);
            this.Lbl_TumMusteriler.TabIndex = 0;
            this.Lbl_TumMusteriler.Text = "Tüm Müşteriler";
            // 
            // DataGridV_TumMusteriler
            // 
            this.DataGridV_TumMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridV_TumMusteriler.Location = new System.Drawing.Point(27, 55);
            this.DataGridV_TumMusteriler.Name = "DataGridV_TumMusteriler";
            this.DataGridV_TumMusteriler.Size = new System.Drawing.Size(574, 355);
            this.DataGridV_TumMusteriler.TabIndex = 1;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.DarkSalmon;
            this.Btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Location = new System.Drawing.Point(516, 417);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 34);
            this.Btn_Sil.TabIndex = 2;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 459);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.DataGridV_TumMusteriler);
            this.Controls.Add(this.Lbl_TumMusteriler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Tüm Müşteriler";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridV_TumMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_TumMusteriler;
        private System.Windows.Forms.DataGridView DataGridV_TumMusteriler;
        private System.Windows.Forms.Button Btn_Sil;
    }
}