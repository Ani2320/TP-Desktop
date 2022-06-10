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
    public partial class Form3 : Form
    {
        private Form formAnterior;
        private String extensionDest;
        private String accion;
        private String mensajeEjecutable;
        private String nombreDeCarpeta;
        public Form3()
        {
            InitializeComponent();
        }

        private void iniciarProceso_Click(object sender, EventArgs e)
        {
            switch(this.accion)
            {
                case "MP4": this.cambiarFormato(); break;
                case "MPEG": this.cambiarFormato(); break;
                case "AVI": this.cambiarFormato(); break;
                case "FLV": this.cambiarFormato(); break;
                case "1280x720": this.cambiarResolucion(); break;
                case "854x480": this.cambiarResolucion(); break;
                case "3840x2160": this.cambiarResolucion(); break;
                case "1920x1080": this.cambiarResolucion(); break;
                case "640x360": this.cambiarResolucion(); break;
                case "426x240": this.cambiarResolucion(); break;
                case "2560x1440": this.cambiarResolucion(); break;
                case "extraer audio": this.extraerAudio(); break;
                case "remover audio": this.removerAudio(); break;
                default: this.extraerImagenPorXFrames(); break;
            }


            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine("mkdir " + this.nombreDeCarpeta);
            cmd.StandardInput.WriteLine("cd " + this.nombreDeCarpeta);
            cmd.StandardInput.WriteLine(this.mensajeEjecutable);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            this.estadoDeProceso.Text = "En proceso.................................................";
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            this.estadoDeProceso.Text = "";
            this.Visible = false;
            this.formAnterior.Visible = true;
        }   

        public void Show(String  ruta, Form form, String accion, String extension)
        {
            this.estadoDeProceso.Text = ruta;
            this.formAnterior = form;
            this.extensionDest = extension;
            this.accion = accion;
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formAnterior.Show();
            this.Visible = false;
        }

        private void cambiarFormato()
        {
            this.mensajeEjecutable = "ffmpeg -i " + this.estadoDeProceso.Text + " video_" + this.accion + "_" +
                DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" +
                DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "." + this.extensionDest;
            this.nombreDeCarpeta = "Videos";
        }

        private void extraerAudio()
        {
            this.mensajeEjecutable = "ffmpeg -i " + this.estadoDeProceso.Text + " -vn -ab 256000 audio_MP3_" +
                DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" +
                DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".mp3";
            this.nombreDeCarpeta = "Audios";
        }

        private void removerAudio()
        {
            this.mensajeEjecutable = "ffmpeg -i " + this.estadoDeProceso.Text + " -c -copy -an video_muteado_" + this.accion + "_" +
             DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" +
             DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "." + this.extensionDest;
            this.nombreDeCarpeta = "VideosMuteados";
        }

        private void cambiarResolucion()
        {
            this.mensajeEjecutable = "ffmpeg -i " + this.estadoDeProceso.Text + " -s " + this.accion + " video_reso_editado_" + this.accion + "_" +
             DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" +
             DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "." + this.extensionDest;
            this.nombreDeCarpeta = "VideosResoEditados";
        }

        private void extraerImagenPorXFrames()
        {
            this.mensajeEjecutable = "ffmpeg -i " + this.estadoDeProceso.Text + " -vf fps=" + this.accion + "/1" + " %03d-imagen_extraido_" + this.accion + "_por_X_frames" +
             DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + "-" +
             DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + ".jpg";
            this.nombreDeCarpeta = "ImagenesX" + this.accion + "Frames";
        }
    }
}