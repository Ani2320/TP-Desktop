using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tp_desktop
{
    public partial class Form2 : Form
    {
        private Form1 formAnterior;
        public Form2()
        {
            InitializeComponent();
            this.formAnterior = new Form1();
        }

        public void Show(Form1 frm)
        {
            this.formAnterior = frm;
            int indice = frm.getRuta().IndexOf(".");
            this.formatoLabel.Text = frm.getRuta().Substring(++indice).ToUpper();
            switch(this.formatoLabel.Text)
            {
                case "MP4": this.mp4Button.Enabled = false; break;
                case "MPEG": this.mpegButton.Enabled = false; break;
                case "AVI": this.aviButton.Enabled = false; break;
                case "FLV": this.flvButton.Enabled = false; break;
            }
            this.Show();
        }

        private void volverInicio_Click(object sender, EventArgs e)
        {
            this.formAnterior.Show();
            this.Visible = false;
        }

        private void mp4Button_Click(object sender, EventArgs e)
        {


            Form3 frm3 = new Form3();
            frm3.Show(this.formAnterior.getRuta(), this, "MP4", "mp4");
            this.Visible = false;
        }

        private void aviButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.formAnterior.getRuta(), this, "AVI", "avi");
            this.Visible = false;
        }

        private void mpegButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.formAnterior.getRuta(), this, "MPEG", "mpeg");
            this.Visible = false;
        }

        private void flvButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.formAnterior.getRuta(), this, "FLV", "flv");
            this.Visible = false;
        }
    }
}
