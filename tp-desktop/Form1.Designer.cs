namespace tp_desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.subirButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rutaDelVideo = new System.Windows.Forms.Label();
            this.removerAudio = new System.Windows.Forms.Button();
            this.extraerAudio = new System.Windows.Forms.Button();
            this.cambiarFormato = new System.Windows.Forms.Button();
            this.cambiarResolucion = new System.Windows.Forms.Button();
            this.extraerImagenes = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.borrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subirButton
            // 
            this.subirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subirButton.Location = new System.Drawing.Point(34, 100);
            this.subirButton.Name = "subirButton";
            this.subirButton.Size = new System.Drawing.Size(216, 30);
            this.subirButton.TabIndex = 0;
            this.subirButton.Text = "Subir un video";
            this.subirButton.UseVisualStyleBackColor = true;
            this.subirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rutaDelVideo
            // 
            this.rutaDelVideo.AutoSize = true;
            this.rutaDelVideo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rutaDelVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rutaDelVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaDelVideo.Location = new System.Drawing.Point(313, 105);
            this.rutaDelVideo.Name = "rutaDelVideo";
            this.rutaDelVideo.Size = new System.Drawing.Size(11, 22);
            this.rutaDelVideo.TabIndex = 1;
            this.rutaDelVideo.Text = "\r\n";
            // 
            // removerAudio
            // 
            this.removerAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerAudio.Location = new System.Drawing.Point(70, 458);
            this.removerAudio.Name = "removerAudio";
            this.removerAudio.Size = new System.Drawing.Size(264, 96);
            this.removerAudio.TabIndex = 6;
            this.removerAudio.Text = "Remover audio del video";
            this.removerAudio.UseVisualStyleBackColor = true;
            this.removerAudio.Click += new System.EventHandler(this.removerAudio_Click);
            // 
            // extraerAudio
            // 
            this.extraerAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraerAudio.Location = new System.Drawing.Point(70, 266);
            this.extraerAudio.Name = "extraerAudio";
            this.extraerAudio.Size = new System.Drawing.Size(264, 96);
            this.extraerAudio.TabIndex = 5;
            this.extraerAudio.Text = "Extraer audio del video";
            this.extraerAudio.UseVisualStyleBackColor = true;
            this.extraerAudio.Click += new System.EventHandler(this.extraerAudio_Click);
            // 
            // cambiarFormato
            // 
            this.cambiarFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarFormato.Location = new System.Drawing.Point(450, 368);
            this.cambiarFormato.Name = "cambiarFormato";
            this.cambiarFormato.Size = new System.Drawing.Size(264, 96);
            this.cambiarFormato.TabIndex = 4;
            this.cambiarFormato.Text = "Cambiar formato del video";
            this.cambiarFormato.UseVisualStyleBackColor = true;
            this.cambiarFormato.Click += new System.EventHandler(this.cambiarFormato_Click);
            // 
            // cambiarResolucion
            // 
            this.cambiarResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambiarResolucion.Location = new System.Drawing.Point(832, 266);
            this.cambiarResolucion.Name = "cambiarResolucion";
            this.cambiarResolucion.Size = new System.Drawing.Size(264, 96);
            this.cambiarResolucion.TabIndex = 7;
            this.cambiarResolucion.Text = "Cambiar resolución del video";
            this.cambiarResolucion.UseVisualStyleBackColor = true;
            this.cambiarResolucion.Click += new System.EventHandler(this.cambiarResolucion_Click);
            // 
            // extraerImagenes
            // 
            this.extraerImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraerImagenes.Location = new System.Drawing.Point(832, 458);
            this.extraerImagenes.Name = "extraerImagenes";
            this.extraerImagenes.Size = new System.Drawing.Size(264, 96);
            this.extraerImagenes.TabIndex = 8;
            this.extraerImagenes.Text = "Extaer imágenes del video";
            this.extraerImagenes.UseVisualStyleBackColor = true;
            this.extraerImagenes.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(72, 144);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 18);
            this.errorLabel.TabIndex = 9;
            // 
            // borrarButton
            // 
            this.borrarButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.borrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarButton.Location = new System.Drawing.Point(286, 105);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(21, 23);
            this.borrarButton.TabIndex = 10;
            this.borrarButton.Text = "X";
            this.borrarButton.UseVisualStyleBackColor = false;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 596);
            this.Controls.Add(this.borrarButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.extraerImagenes);
            this.Controls.Add(this.cambiarResolucion);
            this.Controls.Add(this.removerAudio);
            this.Controls.Add(this.extraerAudio);
            this.Controls.Add(this.cambiarFormato);
            this.Controls.Add(this.rutaDelVideo);
            this.Controls.Add(this.subirButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subirButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label rutaDelVideo;
        private System.Windows.Forms.Button removerAudio;
        private System.Windows.Forms.Button extraerAudio;
        private System.Windows.Forms.Button cambiarFormato;
        private System.Windows.Forms.Button cambiarResolucion;
        private System.Windows.Forms.Button extraerImagenes;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button borrarButton;
    }
}

