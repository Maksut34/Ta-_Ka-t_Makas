namespace Taş_Kağıt_Makas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_taş = new System.Windows.Forms.Button();
            this.btn_kağıt = new System.Windows.Forms.Button();
            this.btn_makas = new System.Windows.Forms.Button();
            this.lbl_Ekran = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Puan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UI = new System.Windows.Forms.Label();
            this.PC_puan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.Label();
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_taş
            // 
            this.btn_taş.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_taş.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_taş.Location = new System.Drawing.Point(50, 204);
            this.btn_taş.Name = "btn_taş";
            this.btn_taş.Size = new System.Drawing.Size(116, 108);
            this.btn_taş.TabIndex = 0;
            this.btn_taş.Text = "Taş";
            this.btn_taş.UseVisualStyleBackColor = false;
            this.btn_taş.Click += new System.EventHandler(this.btn_taş_Click);
            // 
            // btn_kağıt
            // 
            this.btn_kağıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kağıt.Location = new System.Drawing.Point(212, 204);
            this.btn_kağıt.Name = "btn_kağıt";
            this.btn_kağıt.Size = new System.Drawing.Size(116, 108);
            this.btn_kağıt.TabIndex = 0;
            this.btn_kağıt.Text = "Kağıt";
            this.btn_kağıt.UseVisualStyleBackColor = true;
            this.btn_kağıt.Click += new System.EventHandler(this.btn_kağıt_Click);
            // 
            // btn_makas
            // 
            this.btn_makas.BackColor = System.Drawing.Color.Beige;
            this.btn_makas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_makas.Location = new System.Drawing.Point(374, 204);
            this.btn_makas.Name = "btn_makas";
            this.btn_makas.Size = new System.Drawing.Size(116, 108);
            this.btn_makas.TabIndex = 0;
            this.btn_makas.Text = "Makas";
            this.btn_makas.UseVisualStyleBackColor = false;
            this.btn_makas.Click += new System.EventHandler(this.btn_makas_Click);
            // 
            // lbl_Ekran
            // 
            this.lbl_Ekran.BackColor = System.Drawing.Color.Black;
            this.lbl_Ekran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Ekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ekran.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_Ekran.Location = new System.Drawing.Point(51, 30);
            this.lbl_Ekran.Name = "lbl_Ekran";
            this.lbl_Ekran.Size = new System.Drawing.Size(277, 95);
            this.lbl_Ekran.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.UI_Puan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UI);
            this.groupBox1.Controls.Add(this.PC_puan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PC);
            this.groupBox1.Location = new System.Drawing.Point(349, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puan tablosu";
            // 
            // UI_Puan
            // 
            this.UI_Puan.AutoSize = true;
            this.UI_Puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UI_Puan.Location = new System.Drawing.Point(88, 69);
            this.UI_Puan.Name = "UI_Puan";
            this.UI_Puan.Size = new System.Drawing.Size(24, 17);
            this.UI_Puan.TabIndex = 0;
            this.UI_Puan.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = ":";
            // 
            // UI
            // 
            this.UI.AutoSize = true;
            this.UI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UI.Location = new System.Drawing.Point(17, 69);
            this.UI.Name = "UI";
            this.UI.Size = new System.Drawing.Size(21, 17);
            this.UI.TabIndex = 0;
            this.UI.Text = "UI";
            // 
            // PC_puan
            // 
            this.PC_puan.AutoSize = true;
            this.PC_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PC_puan.Location = new System.Drawing.Point(88, 43);
            this.PC_puan.Name = "PC_puan";
            this.PC_puan.Size = new System.Drawing.Size(24, 17);
            this.PC_puan.TabIndex = 0;
            this.PC_puan.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = ":";
            // 
            // PC
            // 
            this.PC.AutoSize = true;
            this.PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PC.Location = new System.Drawing.Point(17, 43);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(26, 17);
            this.PC.TabIndex = 0;
            this.PC.Text = "PC";
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Location = new System.Drawing.Point(54, 142);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(0, 13);
            this.lbl_mesaj.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(50, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(137, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tebrikler! Siz kazandınız!";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(539, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Ekran);
            this.Controls.Add(this.btn_makas);
            this.Controls.Add(this.btn_kağıt);
            this.Controls.Add(this.btn_taş);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_taş;
        private System.Windows.Forms.Button btn_kağıt;
        private System.Windows.Forms.Button btn_makas;
        private System.Windows.Forms.Label lbl_Ekran;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Label UI_Puan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UI;
        private System.Windows.Forms.Label PC_puan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

