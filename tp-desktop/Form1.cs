using System;
using System.Windows.Forms;

namespace tp_desktop
{
    public partial class Form1 : Form
    {
        private string inicial_label = "Aquí se mostrará la ruta del video seleccionado";
        private string error_video_no_seleccionado = "Es obligatorio seleccionar un archivo.(*)";

        public Form1()
        {
            InitializeComponent();
            this.rutaDelVideo.Text = this.inicial_label;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Todos los archivos multimedia|*.mp4; *.avi; *.mpeg; *.flv";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                this.rutaDelVideo.Text = (openFileDialog1.FileName);
                this.errorLabel.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.rutaDelVideo.Text.Equals(this.inicial_label))
            {
                Form5 frm5 = new Form5();
                frm5.Show(this.rutaDelVideo.Text, this);
                this.Visible = false;
            }
            else
                this.errorLabel.Text = this.error_video_no_seleccionado;

        }

        private void extraerAudio_Click(object sender, EventArgs e)
        {
            if (!this.rutaDelVideo.Text.Equals(this.inicial_label))
            {
                Form3 frm3 = new Form3();
                frm3.Show(this.rutaDelVideo.Text, this, "extraer audio", "");
                this.Visible = false;
            }
            else
                this.errorLabel.Text = this.error_video_no_seleccionado;


        }

        private void removerAudio_Click(object sender, EventArgs e)
        {
            if (!this.rutaDelVideo.Text.Equals(this.inicial_label))
            {
                Form3 frm3 = new Form3();
                frm3.Show(this.rutaDelVideo.Text, this, "remover audio", "");
                this.Visible = false;
            }
            else
                this.errorLabel.Text = this.error_video_no_seleccionado;

        }

        private void cambiarResolucion_Click(object sender, EventArgs e)
        {
            if (!this.rutaDelVideo.Text.Equals(this.inicial_label))
            {
                Form4 frm4 = new Form4();
                frm4.Show(this.rutaDelVideo.Text, this);
                this.Visible = false;
            }
            else
                this.errorLabel.Text = this.error_video_no_seleccionado;

        }

        private void cambiarFormato_Click(object sender, EventArgs e)
        {
            if (!this.rutaDelVideo.Text.Equals(this.inicial_label))
            {
                Form2 frm2 = new Form2();
                frm2.Show(this);
                this.Visible = false;
            }
            else
                this.errorLabel.Text = this.error_video_no_seleccionado;
        }

        private void borrarButton_Click_1(object sender, EventArgs e)
        {
            this.rutaDelVideo.Text = this.inicial_label;
        }

        public string getRuta()
        { return this.rutaDelVideo.Text; }
    }
}
