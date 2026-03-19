namespace APPGESTOR_CSHARP
{
    partial class frmCadastrarAluno
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
            this.dgvCadastroAlunos = new System.Windows.Forms.DataGridView();
            this.gbCadastrarAluno = new System.Windows.Forms.GroupBox();
            this.lblCargoColaborador = new System.Windows.Forms.Label();
            this.lblMatriculaColaborador = new System.Windows.Forms.Label();
            this.lblCadCPF = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.cbbCursoAluno = new System.Windows.Forms.ComboBox();
            this.txtMatriculaAluno = new System.Windows.Forms.TextBox();
            this.txtNomeCadAluno = new System.Windows.Forms.TextBox();
            this.gbBuscarAluno = new System.Windows.Forms.GroupBox();
            this.rbBuscarMatricula = new System.Windows.Forms.RadioButton();
            this.rbBuscarNome = new System.Windows.Forms.RadioButton();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.lblAlunosCadastrados = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApagarAluno = new System.Windows.Forms.Button();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.ttSalvarAluno = new System.Windows.Forms.ToolTip(this.components);
            this.ttAtualizarAluno = new System.Windows.Forms.ToolTip(this.components);
            this.ttApagar = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroAlunos)).BeginInit();
            this.gbCadastrarAluno.SuspendLayout();
            this.gbBuscarAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlRodape.Location = new System.Drawing.Point(-5, 431);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1258, 44);
            this.pnlRodape.TabIndex = 6;
            // 
            // pnlMenuLogin
            // 
            this.pnlMenuLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMenuLogin.Controls.Add(this.pictureBox1);
            this.pnlMenuLogin.Controls.Add(this.btnApagarAluno);
            this.pnlMenuLogin.Controls.Add(this.btnCadastrarAluno);
            this.pnlMenuLogin.Controls.Add(this.btnEditarAluno);
            this.pnlMenuLogin.Location = new System.Drawing.Point(-5, 0);
            this.pnlMenuLogin.Name = "pnlMenuLogin";
            this.pnlMenuLogin.Size = new System.Drawing.Size(1258, 100);
            this.pnlMenuLogin.TabIndex = 5;
            // 
            // dgvCadastroAlunos
            // 
            this.dgvCadastroAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroAlunos.Location = new System.Drawing.Point(724, 136);
            this.dgvCadastroAlunos.Name = "dgvCadastroAlunos";
            this.dgvCadastroAlunos.RowHeadersWidth = 62;
            this.dgvCadastroAlunos.RowTemplate.Height = 28;
            this.dgvCadastroAlunos.Size = new System.Drawing.Size(516, 283);
            this.dgvCadastroAlunos.TabIndex = 7;
            // 
            // gbCadastrarAluno
            // 
            this.gbCadastrarAluno.Controls.Add(this.maskedTextBox1);
            this.gbCadastrarAluno.Controls.Add(this.lblCargoColaborador);
            this.gbCadastrarAluno.Controls.Add(this.lblMatriculaColaborador);
            this.gbCadastrarAluno.Controls.Add(this.lblCadCPF);
            this.gbCadastrarAluno.Controls.Add(this.lblNomeColaborador);
            this.gbCadastrarAluno.Controls.Add(this.cbbCursoAluno);
            this.gbCadastrarAluno.Controls.Add(this.txtMatriculaAluno);
            this.gbCadastrarAluno.Controls.Add(this.txtNomeCadAluno);
            this.gbCadastrarAluno.Location = new System.Drawing.Point(12, 106);
            this.gbCadastrarAluno.Name = "gbCadastrarAluno";
            this.gbCadastrarAluno.Size = new System.Drawing.Size(703, 190);
            this.gbCadastrarAluno.TabIndex = 8;
            this.gbCadastrarAluno.TabStop = false;
            this.gbCadastrarAluno.Text = "Cadastrar aluno:";
            // 
            // lblCargoColaborador
            // 
            this.lblCargoColaborador.AutoSize = true;
            this.lblCargoColaborador.Location = new System.Drawing.Point(351, 119);
            this.lblCargoColaborador.Name = "lblCargoColaborador";
            this.lblCargoColaborador.Size = new System.Drawing.Size(184, 27);
            this.lblCargoColaborador.TabIndex = 7;
            this.lblCargoColaborador.Text = "Curso do aluno:";
            // 
            // lblMatriculaColaborador
            // 
            this.lblMatriculaColaborador.AutoSize = true;
            this.lblMatriculaColaborador.Location = new System.Drawing.Point(350, 35);
            this.lblMatriculaColaborador.Name = "lblMatriculaColaborador";
            this.lblMatriculaColaborador.Size = new System.Drawing.Size(218, 27);
            this.lblMatriculaColaborador.TabIndex = 6;
            this.lblMatriculaColaborador.Text = "Matrícula do aluno:";
            // 
            // lblCadCPF
            // 
            this.lblCadCPF.AutoSize = true;
            this.lblCadCPF.Location = new System.Drawing.Point(1, 119);
            this.lblCadCPF.Name = "lblCadCPF";
            this.lblCadCPF.Size = new System.Drawing.Size(179, 27);
            this.lblCadCPF.TabIndex = 5;
            this.lblCadCPF.Text = "Cadastrar CPF:";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(0, 35);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(183, 27);
            this.lblNomeColaborador.TabIndex = 4;
            this.lblNomeColaborador.Text = "Nome do aluno:";
            // 
            // cbbCursoAluno
            // 
            this.cbbCursoAluno.FormattingEnabled = true;
            this.cbbCursoAluno.Location = new System.Drawing.Point(355, 149);
            this.cbbCursoAluno.Name = "cbbCursoAluno";
            this.cbbCursoAluno.Size = new System.Drawing.Size(337, 35);
            this.cbbCursoAluno.TabIndex = 3;
            // 
            // txtMatriculaAluno
            // 
            this.txtMatriculaAluno.Location = new System.Drawing.Point(355, 65);
            this.txtMatriculaAluno.Name = "txtMatriculaAluno";
            this.txtMatriculaAluno.Size = new System.Drawing.Size(337, 35);
            this.txtMatriculaAluno.TabIndex = 2;
            // 
            // txtNomeCadAluno
            // 
            this.txtNomeCadAluno.Location = new System.Drawing.Point(6, 65);
            this.txtNomeCadAluno.Name = "txtNomeCadAluno";
            this.txtNomeCadAluno.Size = new System.Drawing.Size(337, 35);
            this.txtNomeCadAluno.TabIndex = 0;
            // 
            // gbBuscarAluno
            // 
            this.gbBuscarAluno.Controls.Add(this.rbBuscarMatricula);
            this.gbBuscarAluno.Controls.Add(this.rbBuscarNome);
            this.gbBuscarAluno.Controls.Add(this.txtBuscarAluno);
            this.gbBuscarAluno.Location = new System.Drawing.Point(12, 302);
            this.gbBuscarAluno.Name = "gbBuscarAluno";
            this.gbBuscarAluno.Size = new System.Drawing.Size(703, 117);
            this.gbBuscarAluno.TabIndex = 9;
            this.gbBuscarAluno.TabStop = false;
            this.gbBuscarAluno.Text = "Buscar aluno:";
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
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(355, 50);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(337, 35);
            this.txtBuscarAluno.TabIndex = 8;
            // 
            // lblAlunosCadastrados
            // 
            this.lblAlunosCadastrados.AutoSize = true;
            this.lblAlunosCadastrados.Location = new System.Drawing.Point(719, 106);
            this.lblAlunosCadastrados.Name = "lblAlunosCadastrados";
            this.lblAlunosCadastrados.Size = new System.Drawing.Size(231, 27);
            this.lblAlunosCadastrados.TabIndex = 10;
            this.lblAlunosCadastrados.Text = "Alunos cadastrados:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 149);
            this.maskedTextBox1.Mask = "999,999,999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(338, 35);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPGESTOR_CSHARP.Properties.Resources.quepeLivros;
            this.pictureBox1.Location = new System.Drawing.Point(1148, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnApagarAluno
            // 
            this.btnApagarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarAluno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnApagarAluno.FlatAppearance.BorderSize = 2;
            this.btnApagarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarAluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAluno.ForeColor = System.Drawing.Color.White;
            this.btnApagarAluno.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconApagar;
            this.btnApagarAluno.Location = new System.Drawing.Point(436, 12);
            this.btnApagarAluno.Name = "btnApagarAluno";
            this.btnApagarAluno.Size = new System.Drawing.Size(203, 76);
            this.btnApagarAluno.TabIndex = 3;
            this.ttApagar.SetToolTip(this.btnApagarAluno, "Apagar o registro do aluno!");
            this.btnApagarAluno.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 2;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarAluno.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconsCadastroOperadorMedio;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(18, 12);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(203, 76);
            this.btnCadastrarAluno.TabIndex = 2;
            this.ttSalvarAluno.SetToolTip(this.btnCadastrarAluno, "Salvar o registro do aluno!");
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAluno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarAluno.FlatAppearance.BorderSize = 2;
            this.btnEditarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAluno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.ForeColor = System.Drawing.Color.White;
            this.btnEditarAluno.Image = global::APPGESTOR_CSHARP.Properties.Resources.iconAtualizar;
            this.btnEditarAluno.Location = new System.Drawing.Point(227, 12);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(203, 76);
            this.btnEditarAluno.TabIndex = 1;
            this.ttAtualizarAluno.SetToolTip(this.btnEditarAluno, "Atualizar o registro do aluno!");
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            // 
            // ttSalvarAluno
            // 
            this.ttSalvarAluno.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttSalvarAluno.ToolTipTitle = "Salvar:";
            // 
            // ttAtualizarAluno
            // 
            this.ttAtualizarAluno.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttAtualizarAluno.ToolTipTitle = "Atualizar:";
            // 
            // ttApagar
            // 
            this.ttApagar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttApagar.ToolTipTitle = "Apagar:";
            // 
            // frmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 474);
            this.Controls.Add(this.lblAlunosCadastrados);
            this.Controls.Add(this.gbBuscarAluno);
            this.Controls.Add(this.gbCadastrarAluno);
            this.Controls.Add(this.dgvCadastroAlunos);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlMenuLogin);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCadastrarAluno";
            this.Text = "APLICATIVO GESTOR - Tela de Cadastro de Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarAluno_FormClosed);
            this.pnlMenuLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroAlunos)).EndInit();
            this.gbCadastrarAluno.ResumeLayout(false);
            this.gbCadastrarAluno.PerformLayout();
            this.gbBuscarAluno.ResumeLayout(false);
            this.gbBuscarAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.Panel pnlMenuLogin;
        private System.Windows.Forms.Button btnApagarAluno;
        private System.Windows.Forms.DataGridView dgvCadastroAlunos;
        private System.Windows.Forms.GroupBox gbCadastrarAluno;
        private System.Windows.Forms.GroupBox gbBuscarAluno;
        private System.Windows.Forms.Label lblCargoColaborador;
        private System.Windows.Forms.Label lblMatriculaColaborador;
        private System.Windows.Forms.Label lblCadCPF;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.ComboBox cbbCursoAluno;
        private System.Windows.Forms.TextBox txtMatriculaAluno;
        private System.Windows.Forms.TextBox txtNomeCadAluno;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.RadioButton rbBuscarMatricula;
        private System.Windows.Forms.RadioButton rbBuscarNome;
        private System.Windows.Forms.Label lblAlunosCadastrados;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttSalvarAluno;
        private System.Windows.Forms.ToolTip ttAtualizarAluno;
        private System.Windows.Forms.ToolTip ttApagar;
    }
}