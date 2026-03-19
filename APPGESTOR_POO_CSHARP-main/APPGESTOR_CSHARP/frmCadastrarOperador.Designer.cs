namespace APPGESTOR_CSHARP
{
    partial class frmCadastrarOperador
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
            this.components = new System.ComponentModel.Container();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlMenuLogin = new System.Windows.Forms.Panel();
            this.dgvCadastroOperadores = new System.Windows.Forms.DataGridView();
            this.gbCadastrarOperador = new System.Windows.Forms.GroupBox();
            this.gbBuscarOperador = new System.Windows.Forms.GroupBox();
            this.txtNomeCadColaborador = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtMatriculaColaborador = new System.Windows.Forms.TextBox();
            this.cbbCargoColaborador = new System.Windows.Forms.ComboBox();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.lblCargoColaborador = new System.Windows.Forms.Label();
            this.lblMatriculaColaborador = new System.Windows.Forms.Label();
            this.txtBuscarColaborador = new System.Windows.Forms.TextBox();
            this.rbBuscarNome = new System.Windows.Forms.RadioButton();
            this.rbBuscarMatricula = new System.Windows.Forms.RadioButton();
            this.lblCadastrados = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApagarColaborador = new System.Windows.Forms.Button();
            this.btnCadastrarOperador = new System.Windows.Forms.Button();
            this.btnEditarColaborador = new System.Windows.Forms.Button();
            this.ttSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEditar = new System.Windows.Forms.ToolTip(this.components);
            this.ttApagar = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroOperadores)).BeginInit();
            this.gbCadastrarOperador.SuspendLayout();
            this.gbBuscarOperador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlRodape.Location = new System.Drawing.Point(-5, 634);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(755, 44);
            this.pnlRodape.TabIndex = 6;
            // 
            // pnlMenuLogin
            // 
            this.pnlMenuLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMenuLogin.Controls.Add(this.pictureBox1);
            this.pnlMenuLogin.Controls.Add(this.btnApagarColaborador);
            this.pnlMenuLogin.Controls.Add(this.btnCadastrarOperador);
            this.pnlMenuLogin.Controls.Add(this.btnEditarColaborador);
            this.pnlMenuLogin.Location = new System.Drawing.Point(-5, 0);
            this.pnlMenuLogin.Name = "pnlMenuLogin";
            this.pnlMenuLogin.Size = new System.Drawing.Size(755, 100);
            this.pnlMenuLogin.TabIndex = 5;
            // 
            // dgvCadastroOperadores
            // 
            this.dgvCadastroOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroOperadores.Location = new System.Drawing.Point(12, 479);
            this.dgvCadastroOperadores.Name = "dgvCadastroOperadores";
            this.dgvCadastroOperadores.RowHeadersWidth = 62;
            this.dgvCadastroOperadores.RowTemplate.Height = 28;
            this.dgvCadastroOperadores.Size = new System.Drawing.Size(725, 149);
            this.dgvCadastroOperadores.TabIndex = 7;
            // 
            // gbCadastrarOperador
            // 
            this.gbCadastrarOperador.Controls.Add(this.lblCargoColaborador);
            this.gbCadastrarOperador.Controls.Add(this.lblMatriculaColaborador);
            this.gbCadastrarOperador.Controls.Add(this.lblCadSenha);
            this.gbCadastrarOperador.Controls.Add(this.lblNomeColaborador);
            this.gbCadastrarOperador.Controls.Add(this.cbbCargoColaborador);
            this.gbCadastrarOperador.Controls.Add(this.txtMatriculaColaborador);
            this.gbCadastrarOperador.Controls.Add(this.txtCadSenha);
            this.gbCadastrarOperador.Controls.Add(this.txtNomeCadColaborador);
            this.gbCadastrarOperador.Location = new System.Drawing.Point(12, 106);
            this.gbCadastrarOperador.Name = "gbCadastrarOperador";
            this.gbCadastrarOperador.Size = new System.Drawing.Size(725, 190);
            this.gbCadastrarOperador.TabIndex = 8;
            this.gbCadastrarOperador.TabStop = false;
            this.gbCadastrarOperador.Text = "Cadastrar operador:";
            // 
            // gbBuscarOperador
            // 
            this.gbBuscarOperador.Controls.Add(this.rbBuscarMatricula);
            this.gbBuscarOperador.Controls.Add(this.rbBuscarNome);
            this.gbBuscarOperador.Controls.Add(this.txtBuscarColaborador);
            this.gbBuscarOperador.Location = new System.Drawing.Point(12, 302);
            this.gbBuscarOperador.Name = "gbBuscarOperador";
            this.gbBuscarOperador.Size = new System.Drawing.Size(725, 117);
            this.gbBuscarOperador.TabIndex = 9;
            this.gbBuscarOperador.TabStop = false;
            this.gbBuscarOperador.Text = "Buscar operador:";
            // 
            // txtNomeCadColaborador
            // 
            this.txtNomeCadColaborador.Location = new System.Drawing.Point(6, 65);
            this.txtNomeCadColaborador.Name = "txtNomeCadColaborador";
            this.txtNomeCadColaborador.Size = new System.Drawing.Size(337, 35);
            this.txtNomeCadColaborador.TabIndex = 0;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(6, 149);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(337, 35);
            this.txtCadSenha.TabIndex = 1;
            // 
            // txtMatriculaColaborador
            // 
            this.txtMatriculaColaborador.Location = new System.Drawing.Point(382, 65);
            this.txtMatriculaColaborador.Name = "txtMatriculaColaborador";
            this.txtMatriculaColaborador.Size = new System.Drawing.Size(337, 35);
            this.txtMatriculaColaborador.TabIndex = 2;
            // 
            // cbbCargoColaborador
            // 
            this.cbbCargoColaborador.FormattingEnabled = true;
            this.cbbCargoColaborador.Location = new System.Drawing.Point(382, 149);
            this.cbbCargoColaborador.Name = "cbbCargoColaborador";
            this.cbbCargoColaborador.Size = new System.Drawing.Size(337, 35);
            this.cbbCargoColaborador.TabIndex = 3;
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(0, 35);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(250, 27);
            this.lblNomeColaborador.TabIndex = 4;
            this.lblNomeColaborador.Text = "Nome do colaborador:";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Location = new System.Drawing.Point(1, 119);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(197, 27);
            this.lblCadSenha.TabIndex = 5;
            this.lblCadSenha.Text = "Cadastrar senha:";
            // 
            // lblCargoColaborador
            // 
            this.lblCargoColaborador.AutoSize = true;
            this.lblCargoColaborador.Location = new System.Drawing.Point(378, 119);
            this.lblCargoColaborador.Name = "lblCargoColaborador";
            this.lblCargoColaborador.Size = new System.Drawing.Size(252, 27);
            this.lblCargoColaborador.TabIndex = 7;
            this.lblCargoColaborador.Text = "Cargo do colaborador:";
            // 
            // lblMatriculaColaborador
            // 
            this.lblMatriculaColaborador.AutoSize = true;
            this.lblMatriculaColaborador.Location = new System.Drawing.Point(377, 35);
            this.lblMatriculaColaborador.Name = "lblMatriculaColaborador";
            this.lblMatriculaColaborador.Size = new System.Drawing.Size(285, 27);
            this.lblMatriculaColaborador.TabIndex = 6;
            this.lblMatriculaColaborador.Text = "Matrícula do colaborador:";
            // 
            // txtBuscarColaborador
            // 
            this.txtBuscarColaborador.Location = new System.Drawing.Point(382, 50);
            this.txtBuscarColaborador.Name = "txtBuscarColaborador";
            this.txtBuscarColaborador.Size = new System.Drawing.Size(337, 35);
            this.txtBuscarColaborador.TabIndex = 8;
            // 
            // rbBuscarNome
            // 
            this.rbBuscarNome.AutoSize = true;
            this.rbBuscarNome.Location = new System.Drawing.Point(6, 54);
            this.rbBuscarNome.Name = "rbBuscarNome";
            this.rbBuscarNome.Size = new System.Drawing.Size(100, 31);
            this.rbBuscarNome.TabIndex = 9;
            this.rbBuscarNome.TabStop = true;
            this.rbBuscarNome.Text = "Nome";
            this.rbBuscarNome.UseVisualStyleBackColor = true;
            // 
            // rbBuscarMatricula
            // 
            this.rbBuscarMatricula.AutoSize = true;
            this.rbBuscarMatricula.Location = new System.Drawing.Point(167, 54);
            this.rbBuscarMatricula.Name = "rbBuscarMatricula";
            this.rbBuscarMatricula.Size = new System.Drawing.Size(135, 31);
            this.rbBuscarMatricula.TabIndex = 10;
            this.rbBuscarMatricula.TabStop = true;
            this.rbBuscarMatricula.Text = "Matrícula";
            this.rbBuscarMatricula.UseVisualStyleBackColor = true;
            // 
            // lblCadastrados
            // 
            this.lblCadastrados.AutoSize = true;
            this.lblCadastrados.Location = new System.Drawing.Point(7, 449);
            this.lblCadastrados.Name = "lblCadastrados";
            this.lblCadastrados.Size = new System.Drawing.Size(314, 27);
            this.lblCadastrados.TabIndex = 10;
            this.lblCadastrados.Text = "Colaboradores cadastrados:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPGESTOR_CSHARP.Properties.Resources.funcionario;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnApagarColaborador
            // 
            this.btnApagarColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarColaborador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagarColaborador.FlatAppearance.BorderSize = 2;
            this.btnApagarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarColaborador.ForeColor = System.Drawing.Color.White;
            this.btnApagarColaborador.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconApagar;
            this.btnApagarColaborador.Location = new System.Drawing.Point(539, 12);
            this.btnApagarColaborador.Name = "btnApagarColaborador";
            this.btnApagarColaborador.Size = new System.Drawing.Size(203, 76);
            this.btnApagarColaborador.TabIndex = 3;
            this.ttApagar.SetToolTip(this.btnApagarColaborador, "Apagar o registro do colaborador!");
            this.btnApagarColaborador.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarOperador
            // 
            this.btnCadastrarOperador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarOperador.FlatAppearance.BorderSize = 2;
            this.btnCadastrarOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarOperador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOperador.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarOperador.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconsCadastroOperadorMedio;
            this.btnCadastrarOperador.Location = new System.Drawing.Point(121, 12);
            this.btnCadastrarOperador.Name = "btnCadastrarOperador";
            this.btnCadastrarOperador.Size = new System.Drawing.Size(203, 76);
            this.btnCadastrarOperador.TabIndex = 2;
            this.ttSalvar.SetToolTip(this.btnCadastrarOperador, "Salvar o registro do colaborador!");
            this.btnCadastrarOperador.UseVisualStyleBackColor = true;
            // 
            // btnEditarColaborador
            // 
            this.btnEditarColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarColaborador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarColaborador.FlatAppearance.BorderSize = 2;
            this.btnEditarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarColaborador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarColaborador.ForeColor = System.Drawing.Color.White;
            this.btnEditarColaborador.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconAtualizar;
            this.btnEditarColaborador.Location = new System.Drawing.Point(330, 12);
            this.btnEditarColaborador.Name = "btnEditarColaborador";
            this.btnEditarColaborador.Size = new System.Drawing.Size(203, 76);
            this.btnEditarColaborador.TabIndex = 1;
            this.ttEditar.SetToolTip(this.btnEditarColaborador, "Editar o registro do colaborador!");
            this.btnEditarColaborador.UseVisualStyleBackColor = true;
            // 
            // ttSalvar
            // 
            this.ttSalvar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttSalvar.ToolTipTitle = "Salvar:";
            // 
            // ttEditar
            // 
            this.ttEditar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttEditar.ToolTipTitle = "Atualizar:";
            // 
            // ttApagar
            // 
            this.ttApagar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttApagar.ToolTipTitle = "Apagar:";
            // 
            // frmCadastrarOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 678);
            this.Controls.Add(this.lblCadastrados);
            this.Controls.Add(this.gbBuscarOperador);
            this.Controls.Add(this.gbCadastrarOperador);
            this.Controls.Add(this.dgvCadastroOperadores);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlMenuLogin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCadastrarOperador";
            this.Text = "APLICATIVO GESTOR - Tela de Cadastro de Operador";
            this.pnlMenuLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroOperadores)).EndInit();
            this.gbCadastrarOperador.ResumeLayout(false);
            this.gbCadastrarOperador.PerformLayout();
            this.gbBuscarOperador.ResumeLayout(false);
            this.gbBuscarOperador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnCadastrarOperador;
        private System.Windows.Forms.Button btnEditarColaborador;
        private System.Windows.Forms.Panel pnlMenuLogin;
        private System.Windows.Forms.Button btnApagarColaborador;
        private System.Windows.Forms.DataGridView dgvCadastroOperadores;
        private System.Windows.Forms.GroupBox gbCadastrarOperador;
        private System.Windows.Forms.GroupBox gbBuscarOperador;
        private System.Windows.Forms.Label lblCargoColaborador;
        private System.Windows.Forms.Label lblMatriculaColaborador;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.ComboBox cbbCargoColaborador;
        private System.Windows.Forms.TextBox txtMatriculaColaborador;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtNomeCadColaborador;
        private System.Windows.Forms.TextBox txtBuscarColaborador;
        private System.Windows.Forms.RadioButton rbBuscarMatricula;
        private System.Windows.Forms.RadioButton rbBuscarNome;
        private System.Windows.Forms.Label lblCadastrados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttSalvar;
        private System.Windows.Forms.ToolTip ttEditar;
        private System.Windows.Forms.ToolTip ttApagar;
    }
}