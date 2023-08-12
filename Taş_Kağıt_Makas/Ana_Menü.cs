using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas
{
    public partial class Ana_Menü : Form
    {
        public Ana_Menü()
        {
            InitializeComponent();
        }

        private void btn_yeni_oyun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();

        }

        private void Ana_Menü_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Ana_Menü_FormClosing);
        }
        bool closing = false;
        private void Ana_Menü_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closing && e.CloseReason == CloseReason.UserClosing)
            {
                closing = true;
                DialogResult result = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Program Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    closing = false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
