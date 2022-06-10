using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_desktop
{
    public partial class Form4 : Form
    {
        private Form formAnterior;
        private String rutaDelArchivo;
        private String extension;
        public Form4()
        {
            InitializeComponent();
        }

        private void button42560x1440_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "2560x1440", this.extension);
            this.Visible = false;
        }

        private void voverButton_Click(object sender, EventArgs e)
        {
            this.formAnterior.Show();
            this.Visible = false;
        }

        public void Show(String ruta, Form frm)
        {
            this.rutaDelArchivo = ruta;
            this.formAnterior = frm;
            int i = this.rutaDelArchivo.IndexOf(".");
            this.extension = this.rutaDelArchivo.Substring(++i);
            this.Visible = true;
        }

        private void button1280x720_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "1280x720", this.extension);
            this.Visible = false;
        }

        private void button854x480_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "854x480", this.extension);
            this.Visible = false;
        }

        private void button3840x2160_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "3840x2160", this.extension);
            this.Visible = false;
        }

        private void button1920x1080_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "1920x1080", this.extension);
            this.Visible = false;
        }

        private void button640x360_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "640x360", this.extension);
            this.Visible = false;
        }

        private void button426x240_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, "426x240", this.extension);
            this.Visible = false;
        }
    }
}
