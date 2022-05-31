
namespace ParolaOlusturma
{
    partial class Form1
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
            this.chbKücükHarf = new System.Windows.Forms.CheckBox();
            this.pnlSifre = new System.Windows.Forms.Panel();
            this.btnUret = new System.Windows.Forms.Button();
            this.chbOzelKarakter = new System.Windows.Forms.CheckBox();
            this.lblPanelIsmi = new System.Windows.Forms.Label();
            this.nudSifreUzunlugu = new System.Windows.Forms.NumericUpDown();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblSifreUzunlugu = new System.Windows.Forms.Label();
            this.lblSifreSayisi = new System.Windows.Forms.Label();
            this.chbRakam = new System.Windows.Forms.CheckBox();
            this.chbBuyukHarf = new System.Windows.Forms.CheckBox();
            this.rtxSifreSergile = new System.Windows.Forms.RichTextBox();
            this.pnlSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // chbKücükHarf
            // 
            this.chbKücükHarf.AutoSize = true;
            this.chbKücükHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbKücükHarf.Location = new System.Drawing.Point(14, 20);
            this.chbKücükHarf.Name = "chbKücükHarf";
            this.chbKücükHarf.Size = new System.Drawing.Size(90, 17);
            this.chbKücükHarf.TabIndex = 0;
            this.chbKücükHarf.Text = "Küçük Harf";
            this.chbKücükHarf.UseVisualStyleBackColor = true;
            // 
            // pnlSifre
            // 
            this.pnlSifre.Controls.Add(this.btnUret);
            this.pnlSifre.Controls.Add(this.chbOzelKarakter);
            this.pnlSifre.Controls.Add(this.lblPanelIsmi);
            this.pnlSifre.Controls.Add(this.nudSifreUzunlugu);
            this.pnlSifre.Controls.Add(this.nudSifreSayisi);
            this.pnlSifre.Controls.Add(this.lblSifreUzunlugu);
            this.pnlSifre.Controls.Add(this.lblSifreSayisi);
            this.pnlSifre.Controls.Add(this.chbRakam);
            this.pnlSifre.Controls.Add(this.chbBuyukHarf);
            this.pnlSifre.Controls.Add(this.chbKücükHarf);
            this.pnlSifre.Location = new System.Drawing.Point(15, 12);
            this.pnlSifre.Name = "pnlSifre";
            this.pnlSifre.Size = new System.Drawing.Size(207, 209);
            this.pnlSifre.TabIndex = 3;
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(112, 172);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(75, 34);
            this.btnUret.TabIndex = 8;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // chbOzelKarakter
            // 
            this.chbOzelKarakter.AutoSize = true;
            this.chbOzelKarakter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbOzelKarakter.Location = new System.Drawing.Point(14, 88);
            this.chbOzelKarakter.Name = "chbOzelKarakter";
            this.chbOzelKarakter.Size = new System.Drawing.Size(103, 17);
            this.chbOzelKarakter.TabIndex = 7;
            this.chbOzelKarakter.Text = "Özel Karakter";
            this.chbOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // lblPanelIsmi
            // 
            this.lblPanelIsmi.AutoSize = true;
            this.lblPanelIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPanelIsmi.Location = new System.Drawing.Point(3, -3);
            this.lblPanelIsmi.Name = "lblPanelIsmi";
            this.lblPanelIsmi.Size = new System.Drawing.Size(141, 18);
            this.lblPanelIsmi.TabIndex = 3;
            this.lblPanelIsmi.Text = "PARAMETRELER";
            // 
            // nudSifreUzunlugu
            // 
            this.nudSifreUzunlugu.Location = new System.Drawing.Point(129, 146);
            this.nudSifreUzunlugu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreUzunlugu.Name = "nudSifreUzunlugu";
            this.nudSifreUzunlugu.Size = new System.Drawing.Size(58, 20);
            this.nudSifreUzunlugu.TabIndex = 6;
            this.nudSifreUzunlugu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(129, 117);
            this.nudSifreSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(58, 20);
            this.nudSifreSayisi.TabIndex = 5;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSifreUzunlugu
            // 
            this.lblSifreUzunlugu.AutoSize = true;
            this.lblSifreUzunlugu.Location = new System.Drawing.Point(46, 149);
            this.lblSifreUzunlugu.Name = "lblSifreUzunlugu";
            this.lblSifreUzunlugu.Size = new System.Drawing.Size(82, 13);
            this.lblSifreUzunlugu.TabIndex = 4;
            this.lblSifreUzunlugu.Text = "Şifre Uzunluğu :";
            // 
            // lblSifreSayisi
            // 
            this.lblSifreSayisi.AutoSize = true;
            this.lblSifreSayisi.Location = new System.Drawing.Point(46, 119);
            this.lblSifreSayisi.Name = "lblSifreSayisi";
            this.lblSifreSayisi.Size = new System.Drawing.Size(64, 13);
            this.lblSifreSayisi.TabIndex = 3;
            this.lblSifreSayisi.Text = "Şifre Sayısı :";
            // 
            // chbRakam
            // 
            this.chbRakam.AutoSize = true;
            this.chbRakam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbRakam.Location = new System.Drawing.Point(14, 65);
            this.chbRakam.Name = "chbRakam";
            this.chbRakam.Size = new System.Drawing.Size(65, 17);
            this.chbRakam.TabIndex = 2;
            this.chbRakam.Text = "Rakam";
            this.chbRakam.UseVisualStyleBackColor = true;
            // 
            // chbBuyukHarf
            // 
            this.chbBuyukHarf.AutoSize = true;
            this.chbBuyukHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbBuyukHarf.Location = new System.Drawing.Point(14, 42);
            this.chbBuyukHarf.Name = "chbBuyukHarf";
            this.chbBuyukHarf.Size = new System.Drawing.Size(89, 17);
            this.chbBuyukHarf.TabIndex = 1;
            this.chbBuyukHarf.Text = "Büyük Harf";
            this.chbBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // rtxSifreSergile
            // 
            this.rtxSifreSergile.Location = new System.Drawing.Point(229, 12);
            this.rtxSifreSergile.Name = "rtxSifreSergile";
            this.rtxSifreSergile.Size = new System.Drawing.Size(198, 206);
            this.rtxSifreSergile.TabIndex = 4;
            this.rtxSifreSergile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 233);
            this.Controls.Add(this.pnlSifre);
            this.Controls.Add(this.rtxSifreSergile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSifre.ResumeLayout(false);
            this.pnlSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunlugu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbKücükHarf;
        private System.Windows.Forms.Panel pnlSifre;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.CheckBox chbOzelKarakter;
        private System.Windows.Forms.Label lblPanelIsmi;
        private System.Windows.Forms.NumericUpDown nudSifreUzunlugu;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.Label lblSifreUzunlugu;
        private System.Windows.Forms.Label lblSifreSayisi;
        private System.Windows.Forms.CheckBox chbRakam;
        private System.Windows.Forms.CheckBox chbBuyukHarf;
        private System.Windows.Forms.RichTextBox rtxSifreSergile;
    }
}

