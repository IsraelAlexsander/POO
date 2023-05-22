namespace WindowsForms_Formulario
{
    partial class FrmContagem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContagem = new System.Windows.Forms.Label();
            this.btnChamaIncremento = new System.Windows.Forms.Button();
            this.txtContagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.Location = new System.Drawing.Point(92, 47);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(55, 13);
            this.lblContagem.TabIndex = 0;
            this.lblContagem.Text = "Contagem";
            // 
            // btnChamaIncremento
            // 
            this.btnChamaIncremento.Location = new System.Drawing.Point(95, 110);
            this.btnChamaIncremento.Name = "btnChamaIncremento";
            this.btnChamaIncremento.Size = new System.Drawing.Size(151, 23);
            this.btnChamaIncremento.TabIndex = 1;
            this.btnChamaIncremento.Text = "Chama Form de Incremento";
            this.btnChamaIncremento.UseVisualStyleBackColor = true;
            this.btnChamaIncremento.Click += new System.EventHandler(this.btnChamaIncremento_Click);
            // 
            // txtContagem
            // 
            this.txtContagem.Location = new System.Drawing.Point(95, 74);
            this.txtContagem.Name = "txtContagem";
            this.txtContagem.Size = new System.Drawing.Size(151, 20);
            this.txtContagem.TabIndex = 2;
            this.txtContagem.Text = "0";
            this.txtContagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmContagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 217);
            this.Controls.Add(this.txtContagem);
            this.Controls.Add(this.btnChamaIncremento);
            this.Controls.Add(this.lblContagem);
            this.Name = "FrmContagem";
            this.Text = "Form de Contagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.Button btnChamaIncremento;
        public System.Windows.Forms.TextBox txtContagem;
    }
}

