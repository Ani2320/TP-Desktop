namespace tp_desktop
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.iniciarProceso = new System.Windows.Forms.Button();
            this.estadoDeProceso = new System.Windows.Forms.Label();
            this.voverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iniciarProceso
            // 
            this.iniciarProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarProceso.Location = new System.Drawing.Point(73, 85);
            this.iniciarProceso.Name = "iniciarProceso";
            this.iniciarProceso.Size = new System.Drawing.Size(170, 50);
            this.iniciarProceso.TabIndex = 0;
            this.iniciarProceso.Text = "Iniciar Proceso";
            this.iniciarProceso.UseVisualStyleBackColor = true;
            this.iniciarProceso.Click += new System.EventHandler(this.iniciarProceso_Click);
            // 
            // estadoDeProceso
            // 
            this.estadoDeProceso.AutoSize = true;
            this.estadoDeProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoDeProceso.Image = ((System.Drawing.Image)(resources.GetObject("estadoDeProceso.Image")));
            this.estadoDeProceso.Location = new System.Drawing.Point(69, 241);
            this.estadoDeProceso.Name = "estadoDeProceso";
            this.estadoDeProceso.Size = new System.Drawing.Size(0, 20);
            this.estadoDeProceso.TabIndex = 1;
            // 
            // voverButton
            // 
            this.voverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voverButton.Location = new System.Drawing.Point(633, 26);
            this.voverButton.Name = "voverButton";
            this.voverButton.Size = new System.Drawing.Size(128, 45);
            this.voverButton.TabIndex = 2;
            this.voverButton.Text = "Volver";
            this.voverButton.UseVisualStyleBackColor = true;
            this.voverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 596);
            this.Controls.Add(this.voverButton);
            this.Controls.Add(this.estadoDeProceso);
            this.Controls.Add(this.iniciarProceso);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iniciarProceso;
        private System.Windows.Forms.Label estadoDeProceso;
        private System.Windows.Forms.Button voverButton;
    }
}