namespace Hastane_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnasistangirisi = new System.Windows.Forms.Button();
            this.btndoktorgirisi = new System.Windows.Forms.Button();
            this.btnhastagirisi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA GİRİŞ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR GİRİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "ASİSTAN GİRİŞ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Projesi.Properties.Resources._360_F_337387862_RLupy2Ts2bONn0biXdCAROpFrS9cwjXE;
            this.pictureBox1.Location = new System.Drawing.Point(291, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnasistangirisi
            // 
            this.btnasistangirisi.BackgroundImage = global::Hastane_Projesi.Properties.Resources.sekreterpng;
            this.btnasistangirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnasistangirisi.Location = new System.Drawing.Point(560, 248);
            this.btnasistangirisi.Name = "btnasistangirisi";
            this.btnasistangirisi.Size = new System.Drawing.Size(198, 137);
            this.btnasistangirisi.TabIndex = 2;
            this.btnasistangirisi.UseVisualStyleBackColor = true;
            this.btnasistangirisi.Click += new System.EventHandler(this.btnasistangirisi_Click);
            // 
            // btndoktorgirisi
            // 
            this.btndoktorgirisi.BackgroundImage = global::Hastane_Projesi.Properties.Resources.doctorpng;
            this.btndoktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktorgirisi.Location = new System.Drawing.Point(329, 248);
            this.btndoktorgirisi.Name = "btndoktorgirisi";
            this.btndoktorgirisi.Size = new System.Drawing.Size(185, 137);
            this.btndoktorgirisi.TabIndex = 1;
            this.btndoktorgirisi.UseVisualStyleBackColor = true;
            this.btndoktorgirisi.Click += new System.EventHandler(this.btndoktorgirisi_Click);
            // 
            // btnhastagirisi
            // 
            this.btnhastagirisi.BackgroundImage = global::Hastane_Projesi.Properties.Resources.patient_png;
            this.btnhastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhastagirisi.Location = new System.Drawing.Point(105, 248);
            this.btnhastagirisi.Name = "btnhastagirisi";
            this.btnhastagirisi.Size = new System.Drawing.Size(177, 137);
            this.btnhastagirisi.TabIndex = 0;
            this.btnhastagirisi.UseVisualStyleBackColor = true;
            this.btnhastagirisi.Click += new System.EventHandler(this.btnhastagirisi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-10, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(860, 99);
            this.label4.TabIndex = 7;
            this.label4.Text = "HASTANE OTOMASYONU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(861, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnasistangirisi);
            this.Controls.Add(this.btndoktorgirisi);
            this.Controls.Add(this.btnhastagirisi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HASTANE OTOMASYONU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhastagirisi;
        private System.Windows.Forms.Button btndoktorgirisi;
        private System.Windows.Forms.Button btnasistangirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

