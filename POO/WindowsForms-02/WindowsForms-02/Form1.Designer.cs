namespace WindowsForms_02
{
    partial class trkVolume
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.mkdData = new System.Windows.Forms.MaskedTextBox();
            this.lnkPUCMINAS = new System.Windows.Forms.LinkLabel();
            this.mthCalendario = new System.Windows.Forms.MonthCalendar();
            this.trVolume = new System.Windows.Forms.TrackBar();
            this.pgsVolume = new System.Windows.Forms.ProgressBar();
            this.nmcVolume = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVolume)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoFeminino);
            this.panel1.Controls.Add(this.rdoMasculino);
            this.panel1.Location = new System.Drawing.Point(64, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 100);
            this.panel1.TabIndex = 0;
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(0, 58);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdoFeminino.TabIndex = 1;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            this.rdoFeminino.CheckedChanged += new System.EventHandler(this.rdoFeminino_CheckedChanged);
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Location = new System.Drawing.Point(0, 17);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(75, 17);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculíno";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            this.rdoMasculino.CheckedChanged += new System.EventHandler(this.rdoMasculino_CheckedChanged);
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(64, 148);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(92, 17);
            this.chkBackup.TabIndex = 2;
            this.chkBackup.Text = "Fazer Backup";
            this.chkBackup.UseVisualStyleBackColor = true;
            this.chkBackup.CheckedChanged += new System.EventHandler(this.chkBackup_CheckedChanged);
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "Belo Horizonte",
            "São Paulo",
            "Curitiba",
            "Brasilia",
            "Porto Alegre"});
            this.cboEstados.Location = new System.Drawing.Point(181, 42);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 21);
            this.cboEstados.TabIndex = 3;
            this.cboEstados.Text = "Selecione";
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // mkdData
            // 
            this.mkdData.Location = new System.Drawing.Point(64, 171);
            this.mkdData.Mask = "00/00/0000";
            this.mkdData.Name = "mkdData";
            this.mkdData.Size = new System.Drawing.Size(68, 20);
            this.mkdData.TabIndex = 4;
            this.mkdData.ValidatingType = typeof(System.DateTime);
            // 
            // lnkPUCMINAS
            // 
            this.lnkPUCMINAS.AutoSize = true;
            this.lnkPUCMINAS.Location = new System.Drawing.Point(181, 81);
            this.lnkPUCMINAS.Name = "lnkPUCMINAS";
            this.lnkPUCMINAS.Size = new System.Drawing.Size(66, 13);
            this.lnkPUCMINAS.TabIndex = 5;
            this.lnkPUCMINAS.TabStop = true;
            this.lnkPUCMINAS.Text = "PUC MINAS";
            this.lnkPUCMINAS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPUCMINAS_LinkClicked);
            // 
            // mthCalendario
            // 
            this.mthCalendario.Location = new System.Drawing.Point(64, 203);
            this.mthCalendario.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.mthCalendario.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.mthCalendario.Name = "mthCalendario";
            this.mthCalendario.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2023, 1, 1, 0, 0, 0, 0), new System.DateTime(2023, 1, 7, 0, 0, 0, 0));
            this.mthCalendario.ShowToday = false;
            this.mthCalendario.TabIndex = 6;
            this.mthCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mthCalendario_DateSelected);
            // 
            // trVolume
            // 
            this.trVolume.Location = new System.Drawing.Point(388, 42);
            this.trVolume.Maximum = 100;
            this.trVolume.Name = "trVolume";
            this.trVolume.Size = new System.Drawing.Size(104, 45);
            this.trVolume.TabIndex = 7;
            this.trVolume.Value = 50;
            this.trVolume.Scroll += new System.EventHandler(this.trVolume_Scroll);
            // 
            // pgsVolume
            // 
            this.pgsVolume.Location = new System.Drawing.Point(388, 94);
            this.pgsVolume.Name = "pgsVolume";
            this.pgsVolume.Size = new System.Drawing.Size(100, 23);
            this.pgsVolume.TabIndex = 8;
            this.pgsVolume.Value = 50;
            // 
            // nmcVolume
            // 
            this.nmcVolume.Location = new System.Drawing.Point(494, 97);
            this.nmcVolume.Name = "nmcVolume";
            this.nmcVolume.Size = new System.Drawing.Size(47, 20);
            this.nmcVolume.TabIndex = 9;
            this.nmcVolume.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmcVolume.ValueChanged += new System.EventHandler(this.nmcVolume_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // trkVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.nmcVolume);
            this.Controls.Add(this.pgsVolume);
            this.Controls.Add(this.trVolume);
            this.Controls.Add(this.mthCalendario);
            this.Controls.Add(this.lnkPUCMINAS);
            this.Controls.Add(this.mkdData);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.chkBackup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "trkVolume";
            this.Text = "Controles Visuais";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcVolume)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.CheckBox chkBackup;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.MaskedTextBox mkdData;
        private System.Windows.Forms.LinkLabel lnkPUCMINAS;
        private System.Windows.Forms.MonthCalendar mthCalendario;
        private System.Windows.Forms.TrackBar trVolume;
        private System.Windows.Forms.ProgressBar pgsVolume;
        private System.Windows.Forms.NumericUpDown nmcVolume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

