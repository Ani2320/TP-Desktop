namespace tp_desktop
{
    partial class Form2
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
            this.titulo = new System.Windows.Forms.Label();
            this.actualLabel = new System.Windows.Forms.Label();
            this.formatoLabel = new System.Windows.Forms.Label();
            this.mp4Button = new System.Windows.Forms.Button();
            this.aviButton = new System.Windows.Forms.Button();
            this.mpegButton = new System.Windows.Forms.Button();
            this.flvButton = new System.Windows.Forms.Button();
            this.volverInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(175, 34);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(612, 55);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Cambiar formato del video";
            // 
            // actualLabel
            // 
            this.actualLabel.AutoSize = true;
            this.actualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualLabel.Location = new System.Drawing.Point(231, 166);
            this.actualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actualLabel.Name = "actualLabel";
            this.actualLabel.Size = new System.Drawing.Size(386, 33);
            this.actualLabel.TabIndex = 1;
            this.actualLabel.Text = "Formato actual    _________";
            // 
            // formatoLabel
            // 
            this.formatoLabel.AutoSize = true;
            this.formatoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoLabel.Location = new System.Drawing.Point(636, 174);
            this.formatoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formatoLabel.Name = "formatoLabel";
            this.formatoLabel.Size = new System.Drawing.Size(0, 33);
            this.formatoLabel.TabIndex = 2;
            // 
            // mp4Button
            // 
            this.mp4Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mp4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp4Button.Location = new System.Drawing.Point(98, 319);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(311, 79);
            this.mp4Button.TabIndex = 3;
            this.mp4Button.Text = "MP4";
            this.mp4Button.UseVisualStyleBackColor = true;
            this.mp4Button.Click += new System.EventHandler(this.mp4Button_Click);
            // 
            // aviButton
            // 
            this.aviButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviButton.Location = new System.Drawing.Point(98, 473);
            this.aviButton.Name = "aviButton";
            this.aviButton.Size = new System.Drawing.Size(311, 79);
            this.aviButton.TabIndex = 4;
            this.aviButton.Text = "AVI";
            this.aviButton.UseVisualStyleBackColor = true;
            this.aviButton.Click += new System.EventHandler(this.aviButton_Click);
            // 
            // mpegButton
            // 
            this.mpegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpegButton.Location = new System.Drawing.Point(570, 319);
            this.mpegButton.Name = "mpegButton";
            this.mpegButton.Size = new System.Drawing.Size(311, 79);
            this.mpegButton.TabIndex = 5;
            this.mpegButton.Text = "MPEG";
            this.mpegButton.UseVisualStyleBackColor = true;
            this.mpegButton.Click += new System.EventHandler(this.mpegButton_Click);
            // 
            // flvButton
            // 
            this.flvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flvButton.Location = new System.Drawing.Point(570, 473);
            this.flvButton.Name = "flvButton";
            this.flvButton.Size = new System.Drawing.Size(311, 79);
            this.flvButton.TabIndex = 6;
            this.flvButton.Text = "FLV";
            this.flvButton.UseVisualStyleBackColor = true;
            this.flvButton.Click += new System.EventHandler(this.flvButton_Click);
            // 
            // volverInicio
            // 
            this.volverInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverInicio.Location = new System.Drawing.Point(857, 12);
            this.volverInicio.Name = "volverInicio";
            this.volverInicio.Size = new System.Drawing.Size(123, 44);
            this.volverInicio.TabIndex = 7;
            this.volverInicio.Text = "Volver al inicio";
            this.volverInicio.UseVisualStyleBackColor = true;
            this.volverInicio.Click += new System.EventHandler(this.volverInicio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 596);
            this.Controls.Add(this.volverInicio);
            this.Controls.Add(this.flvButton);
            this.Controls.Add(this.mpegButton);
            this.Controls.Add(this.aviButton);
            this.Controls.Add(this.mp4Button);
            this.Controls.Add(this.formatoLabel);
            this.Controls.Add(this.actualLabel);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label actualLabel;
        private System.Windows.Forms.Label formatoLabel;
        private System.Windows.Forms.Button mp4Button;
        private System.Windows.Forms.Button aviButton;
        private System.Windows.Forms.Button mpegButton;
        private System.Windows.Forms.Button flvButton;
        private System.Windows.Forms.Button volverInicio;
    }
}