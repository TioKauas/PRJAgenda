using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRJAgenda.Properties;

namespace PRJAgenda
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarTarefa_Click(object sender, EventArgs e)
        {
            #region Verificação dos campos
            if (txtTitulo.Text == "" || txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            if (dateDataF.Value < DateTime.Now)
            {
                MessageBox.Show("Insira uma data final válida");
                return;
            }
            #endregion
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtDescricao.Text = "";
            dateDataI.Value = DateTime.Now;
            dateDataF.Value = DateTime.Now;
        }
    }
}
