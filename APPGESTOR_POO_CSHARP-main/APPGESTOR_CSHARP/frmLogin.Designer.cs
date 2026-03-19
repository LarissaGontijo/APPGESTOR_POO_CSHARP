namespace APPGESTOR_CSHARP
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.pnlMenuLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOnOff = new System.Windows.Forms.TrackBar();
            this.btnCadastrarOperador = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.txtSenhaOperador = new System.Windows.Forms.TextBox();
            this.pnlFrontal = new System.Windows.Forms.Panel();
            this.llblSenhaOperador = new System.Windows.Forms.Label();
            this.lblNomeOperador = new System.Windows.Forms.Label();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ttEntrar = new System.Windows.Forms.ToolTip(this.components);
            this.ttCadastrarColaborador = new System.Windows.Forms.ToolTip(this.components);
            this.ttDesligar = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOnOff)).BeginInit();
            this.pnlFrontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLogin
            // 
            this.pnlMenuLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMenuLogin.Controls.Add(this.label1);
            this.pnlMenuLogin.Controls.Add(this.tbOnOff);
            this.pnlMenuLogin.Controls.Add(this.btnCadastrarOperador);
            this.pnlMenuLogin.Controls.Add(this.btnEntrar);
            this.pnlMenuLogin.Location = new System.Drawing.Point(1, 1);
            this.pnlMenuLogin.Name = "pnlMenuLogin";
            this.pnlMenuLogin.Size = new System.Drawing.Size(798, 100);
            this.pnlMenuLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(703, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "On - Off";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOnOff
            // 
            this.tbOnOff.LargeChange = 2;
            this.tbOnOff.Location = new System.Drawing.Point(713, 9);
            this.tbOnOff.Maximum = 2;
            this.tbOnOff.Minimum = 1;
            this.tbOnOff.Name = "tbOnOff";
            this.tbOnOff.Size = new System.Drawing.Size(64, 45);
            this.tbOnOff.TabIndex = 3;
            this.tbOnOff.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttDesligar.SetToolTip(this.tbOnOff, "Desconectar o sistema!");
            this.tbOnOff.Value = 1;
            this.tbOnOff.Scroll += new System.EventHandler(this.tbOnOff_Scroll);
            // 
            // btnCadastrarOperador
            // 
            this.btnCadastrarOperador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarOperador.FlatAppearance.BorderSize = 2;
            this.btnCadastrarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOperador.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarOperador.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconsCadastroOperadorMedio;
            this.btnCadastrarOperador.Location = new System.Drawing.Point(231, 11);
            this.btnCadastrarOperador.Name = "btnCadastrarOperador";
            this.btnCadastrarOperador.Size = new System.Drawing.Size(203, 76);
            this.btnCadastrarOperador.TabIndex = 2;
            this.ttCadastrarColaborador.SetToolTip(this.btnCadastrarOperador, "Cadastrar colaborador!");
            this.btnCadastrarOperador.UseVisualStyleBackColor = true;
            this.btnCadastrarOperador.Click += new System.EventHandler(this.btnCadastrarOperador_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconEnterMenor;
            this.btnEntrar.Location = new System.Drawing.Point(22, 11);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(203, 76);
            this.btnEntrar.TabIndex = 1;
            this.ttEntrar.SetToolTip(this.btnEntrar, "Entrar no sistema!");
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlRodape.Location = new System.Drawing.Point(1, 470);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(798, 44);
            this.pnlRodape.TabIndex = 4;
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Location = new System.Drawing.Point(439, 274);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.Size = new System.Drawing.Size(320, 26);
            this.txtNomeOperador.TabIndex = 5;
            // 
            // txtSenhaOperador
            // 
            this.txtSenhaOperador.Location = new System.Drawing.Point(439, 361);
            this.txtSenhaOperador.Name = "txtSenhaOperador";
            this.txtSenhaOperador.Size = new System.Drawing.Size(320, 26);
            this.txtSenhaOperador.TabIndex = 6;
            // 
            // pnlFrontal
            // 
            this.pnlFrontal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlFrontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrontal.Controls.Add(this.llblSenhaOperador);
            this.pnlFrontal.Controls.Add(this.lblNomeOperador);
            this.pnlFrontal.Location = new System.Drawing.Point(420, 205);
            this.pnlFrontal.Name = "pnlFrontal";
            this.pnlFrontal.Size = new System.Drawing.Size(358, 234);
            this.pnlFrontal.TabIndex = 7;
            // 
            // llblSenhaOperador
            // 
            this.llblSenhaOperador.AutoSize = true;
            this.llblSenhaOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSenhaOperador.ForeColor = System.Drawing.Color.MidnightBlue;
            this.llblSenhaOperador.Location = new System.Drawing.Point(13, 123);
            this.llblSenhaOperador.Name = "llblSenhaOperador";
            this.llblSenhaOperador.Size = new System.Drawing.Size(162, 19);
            this.llblSenhaOperador.TabIndex = 1;
            this.llblSenhaOperador.Text = "Senha do operador:";
            // 
            // lblNomeOperador
            // 
            this.lblNomeOperador.AutoSize = true;
            this.lblNomeOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeOperador.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomeOperador.Location = new System.Drawing.Point(13, 36);
            this.lblNomeOperador.Name = "lblNomeOperador";
            this.lblNomeOperador.Size = new System.Drawing.Size(158, 19);
            this.lblNomeOperador.TabIndex = 0;
            this.lblNomeOperador.Text = "Nome do operador:";
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTituloLogin.Location = new System.Drawing.Point(472, 102);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(196, 70);
            this.lblTituloLogin.TabIndex = 8;
            this.lblTituloLogin.Text = "Gestão \r\n         Escolar";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbLogo.Image = global::APPGESTOR_CSHARP.Properties.Resources.logoEscola;
            this.pbLogo.Location = new System.Drawing.Point(23, 107);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(391, 348);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // ttEntrar
            // 
            this.ttEntrar.ShowAlways = true;
            this.ttEntrar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttEntrar.ToolTipTitle = "Entrar:";
            // 
            // ttCadastrarColaborador
            // 
            this.ttCadastrarColaborador.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttCadastrarColaborador.ToolTipTitle = "Cadastrar:";
            // 
            // ttDesligar
            // 
            this.ttDesligar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttDesligar.ToolTipTitle = "Desligar:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.txtSenhaOperador);
            this.Controls.Add(this.txtNomeOperador);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlMenuLogin);
            this.Controls.Add(this.pnlFrontal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.pnlMenuLogin.ResumeLayout(false);
            this.pnlMenuLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOnOff)).EndInit();
            this.pnlFrontal.ResumeLayout(false);
            this.pnlFrontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrarOperador;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.TextBox txtSenhaOperador;
        private System.Windows.Forms.Panel pnlFrontal;
        private System.Windows.Forms.Label llblSenhaOperador;
        private System.Windows.Forms.Label lblNomeOperador;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.TrackBar tbOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolTip ttCadastrarColaborador;
        private System.Windows.Forms.ToolTip ttEntrar;
        private System.Windows.Forms.ToolTip ttDesligar;
    }
}

