using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random R = new Random();
        int rastgele;
        int pc_puan;
        int uı_puan;
        private void btn_taş_Click(object sender, EventArgs e)
        {
            btn_taş.Enabled = true;
            rastgele = R.Next(1, 3);

            if (rastgele == 1)
            {
                lbl_Ekran.Text = "Taş";
                if (lbl_Ekran.Text == "Taş")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "Aynı!";
                            }
                            pc_puan += 1;
                            uı_puan += 1;
                            PC_puan.Text = pc_puan.ToString();
                            UI_Puan.Text = uı_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }
            else if (rastgele == 2)
            {
                lbl_Ekran.Text = "Kağıt";
                if (lbl_Ekran.Text == "Kağıt")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1500);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "PC sardı!";
                            }
                            pc_puan += 3;
                            PC_puan.Text = pc_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }

            }
            else if (rastgele == 3)
            {
                lbl_Ekran.Text = "Makas";
                if (lbl_Ekran.Text == "Makas")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1500);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "UI kırdı!";
                            }
                            uı_puan += 3;
                            UI_Puan.Text = pc_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }


        }

        private void btn_kağıt_Click(object sender, EventArgs e)
        {
            btn_kağıt.Enabled = true;
            rastgele = R.Next(1, 4);

            if (rastgele == 1)
            {
                lbl_Ekran.Text = "Taş";
                if (lbl_Ekran.Text == "Taş")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "UI sardı!";
                            }

                            uı_puan += 3;

                            UI_Puan.Text = uı_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }
            else if (rastgele == 2)
            {
                lbl_Ekran.Text = "Kağıt";
                if (lbl_Ekran.Text == "Kağıt")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "Aynı!";
                            }
                            pc_puan += 1;
                            uı_puan += 1;
                            PC_puan.Text = pc_puan.ToString();
                            UI_Puan.Text = uı_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }

            }
            else if (rastgele == 3)
            {
                lbl_Ekran.Text = "Makas";
                if (lbl_Ekran.Text == "Makas")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "PC kesti!";
                            }
                            pc_puan += 3;
                            PC_puan.Text = pc_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }

        }

        private void btn_makas_Click(object sender, EventArgs e)
        {
            btn_kağıt.Enabled = true;
            rastgele = R.Next(1, 4);

            if (rastgele == 1)
            {
                lbl_Ekran.Text = "Taş";
                if (lbl_Ekran.Text == "Taş")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "PC kırdı!";
                            }

                            pc_puan += 3;

                            PC_puan.Text = pc_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }
            else if (rastgele == 2)
            {
                lbl_Ekran.Text = "Kağıt";
                if (lbl_Ekran.Text == "Kağıt")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "UI kesti";
                            }

                            uı_puan += 3;

                            UI_Puan.Text = uı_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }

            }
            else if (rastgele == 3)
            {
                lbl_Ekran.Text = "Makas";
                if (lbl_Ekran.Text == "Makas")
                {
                    btn_taş.Visible = true;
                    btn_kağıt.Visible = true;
                    btn_makas.Visible = true;
                    Thread thread = new Thread(() =>
                    {
                        Thread.Sleep(1000);
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (lbl_Ekran.Text != null)
                            {
                                lbl_mesaj.Text = "";
                                lbl_mesaj.Text = "Aynı!";
                            }
                            pc_puan += 1;
                            PC_puan.Text = pc_puan.ToString();
                            uı_puan += 1;
                            UI_Puan.Text = uı_puan.ToString();

                        });
                        kazanan_kaybeden();
                    });
                    thread.Start();
                }
            }

        }

        public void kazanan_kaybeden()
        {
            if (pc_puan >= 20)
            {
                if (PC_puan.InvokeRequired)
                {
                    PC_puan.Invoke(new MethodInvoker(delegate ()
                    {
                        if (PC_puan.Text == pc_puan.ToString())
                        {
                            MessageBox.Show("Kaybettiniz!");
                            
                            this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);
                        }
                    }));
                }
                

            }
            else if (uı_puan >= 20)
            {
                if (UI_Puan.InvokeRequired)
                {
                    UI_Puan.Invoke(new MethodInvoker(delegate ()
                    {
                        
                        if (UI_Puan.Text == uı_puan.ToString())
                        {
                            groupBox2.Show();
                            //PictureBox pictureBox = new PictureBox();
                            //pictureBox.Image = Image.FromFile(@"C:\Users\Maksut\OneDrive\Masaüstü\Proje Resimleri\resim.jpg");
                            //this.Controls.Add(pictureBox);
                            //Ana_Menü a = new Ana_Menü();
                            //this.Close();
                            //a.Show();
                        }
                    }));
                }
            }
            else if (pc_puan >= 20 && uı_puan >= 20)
            {
                if (UI_Puan.InvokeRequired || PC_puan.InvokeRequired)
                {
                    UI_Puan.Invoke(new MethodInvoker(delegate ()
                    {
                        PC_puan.Invoke(new MethodInvoker(delegate ()
                        {
                            if (UI_Puan.Text == uı_puan.ToString() && PC_puan.Text == pc_puan.ToString())
                            {
                                
                                MessageBox.Show("Berebere!:D");
                               
                                this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);
                            }
                        }));
                    }));
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Hide();
            this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);
        }
        bool closing = false;
        private void Ana_Menü_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing && e.CloseReason == CloseReason.UserClosing)
            {
                closing = true;
                DialogResult result = MessageBox.Show("Ana Menüye gitmek istediğinize emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    closing = false;
                }
                else
                {
                    Ana_Menü a = new Ana_Menü();
                    this.Close(); 
                    a.Show();
                }
            }
        }
    }
}
