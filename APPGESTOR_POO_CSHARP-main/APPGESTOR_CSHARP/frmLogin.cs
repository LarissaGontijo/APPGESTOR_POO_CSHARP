using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPGESTOR_CSHARP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbOnOff_Scroll(object sender, EventArgs e)
        {
            if (tbOnOff.Value == 2)
            {
                MessageBox.Show("Sistema desconectado com sucesso!");
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string NomeOperador = txtNomeOperador.Text;
            string SenhaOperador = txtSenhaOperador.Text;


            frmCadastrarAluno fca = new frmCadastrarAluno();
            fca.Show();
            this.Visible = false;
        }

        private void btnCadastrarOperador_Click(object sender, EventArgs e)
        {
            frmCadastrarOperador fco = new frmCadastrarOperador();
            fco.ShowDialog();
        }
    }
}
