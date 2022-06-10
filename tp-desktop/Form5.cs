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
    public partial class Form5 : Form
    {
        private Form formAnterior;
        private String rutaDelArchivo;
        private String extension;
        public Form5()
        {
            InitializeComponent();
            this.textBox1.Text = "1";
        }

        private void voverButton_Click(object sender, EventArgs e)
        {
            this.formAnterior.Show();
            this.Visible = false;
           
        }

        public void Show(String ruta, Form frm)
        {
            this.formAnterior = frm;
            this.rutaDelArchivo = ruta;
            int indice = ruta.IndexOf(".");
            this.extension = ruta.Substring(++indice);
            this.Show();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show(this.rutaDelArchivo, this, this.textBox1.Text, this.extension);
            this.Visible = false;
        }
    }
}
