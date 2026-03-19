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
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void frmCadastrarAluno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
