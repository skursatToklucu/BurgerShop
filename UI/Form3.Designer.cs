
namespace UI
{
    partial class Form3
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
            this.grpEkstraMalzemeEkle = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nmrEkstraMalzemeFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzemeEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzemeEkle
            // 
            this.grpEkstraMalzemeEkle.Controls.Add(this.btnKaydet);
            this.grpEkstraMalzemeEkle.Controls.Add(this.nmrEkstraMalzemeFiyat);
            this.grpEkstraMalzemeEkle.Controls.Add(this.txtEkstraMalzemeAdi);
            this.grpEkstraMalzemeEkle.Controls.Add(this.label2);
            this.grpEkstraMalzemeEkle.Controls.Add(this.label1);
            this.grpEkstraMalzemeEkle.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzemeEkle.Name = "grpEkstraMalzemeEkle";
            this.grpEkstraMalzemeEkle.Size = new System.Drawing.Size(288, 143);
            this.grpEkstraMalzemeEkle.TabIndex = 1;
            this.grpEkstraMalzemeEkle.TabStop = false;
            this.grpEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.grpEkstraMalzemeEkle.Enter += new System.EventHandler(this.grpEkstraMalzemeEkle_Enter);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(156, 87);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 45);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // nmrEkstraMalzemeFiyat
            // 
            this.nmrEkstraMalzemeFiyat.Location = new System.Drawing.Point(163, 58);
            this.nmrEkstraMalzemeFiyat.Name = "nmrEkstraMalzemeFiyat";
            this.nmrEkstraMalzemeFiyat.Size = new System.Drawing.Size(105, 23);
            this.nmrEkstraMalzemeFiyat.TabIndex = 2;
            // 
            // txtEkstraMalzemeAdi
            // 
            this.txtEkstraMalzemeAdi.Location = new System.Drawing.Point(163, 29);
            this.txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            this.txtEkstraMalzemeAdi.Size = new System.Drawing.Size(105, 23);
            this.txtEkstraMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Adı :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 164);
            this.Controls.Add(this.grpEkstraMalzemeEkle);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpEkstraMalzemeEkle.ResumeLayout(false);
            this.grpEkstraMalzemeEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzemeFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzemeEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzemeFiyat;
        private System.Windows.Forms.TextBox txtEkstraMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}