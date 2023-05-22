namespace WindowsForms_Formulario
{
    partial class frmIncremento
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
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.lblContagem = new System.Windows.Forms.Label();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnFechaForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Location = new System.Drawing.Point(58, 62);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(218, 13);
            this.lblInformacoes.TabIndex = 0;
            this.lblInformacoes.Text = "Contagem Registrada No Form de Contagem";
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.Location = new System.Drawing.Point(299, 62);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(10, 13);
            this.lblContagem.TabIndex = 1;
            this.lblContagem.Text = "-";
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(109, 95);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(42, 38);
            this.btnMais.TabIndex = 2;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(202, 95);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(42, 38);
            this.btnMenos.TabIndex = 3;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnFechaForm
            // 
            this.btnFechaForm.Location = new System.Drawing.Point(61, 149);
            this.btnFechaForm.Name = "btnFechaForm";
            this.btnFechaForm.Size = new System.Drawing.Size(215, 23);
            this.btnFechaForm.TabIndex = 4;
            this.btnFechaForm.Text = "Fechar Form de Incremento";
            this.btnFechaForm.UseVisualStyleBackColor = true;
            this.btnFechaForm.Click += new System.EventHandler(this.btnFechaForm_Click);
            // 
            // frmIncremento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 217);
            this.Controls.Add(this.btnFechaForm);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.lblInformacoes);
            this.Name = "frmIncremento";
            this.Text = "Form de Incremento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnFechaForm;
        public System.Windows.Forms.Label lblContagem;
    }
}