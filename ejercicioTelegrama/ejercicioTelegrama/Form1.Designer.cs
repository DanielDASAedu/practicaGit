namespace ejercicioTelegrama
{
    partial class Form1
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(207, 144);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(389, 111);
            this.txtTelegrama.TabIndex = 11;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(204, 114);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(42, 15);
            this.lblTexto.TabIndex = 10;
            this.lblTexto.Text = "Texto";
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(207, 275);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(70, 17);
            this.chkUrgente.TabIndex = 9;
            this.chkUrgente.Text = "Urgente?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(257, 316);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(204, 317);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(47, 15);
            this.lblCoste.TabIndex = 7;
            this.lblCoste.Text = "Coste:";
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(490, 290);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(106, 42);
            this.btnCalcularPrecio.TabIndex = 6;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Button btnCalcularPrecio;
    }
}

