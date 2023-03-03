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
        public  bool Clicou = false;

        public Cadastro()
        {
            InitializeComponent();
        }

        public void btnSalvarTarefa_Click(object sender, EventArgs e)
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

            #region Captação de dados
            Settings.Default["Titulo"] = txtTitulo.Text.Trim();
            Settings.Default["Descricao"] = txtDescricao.Text.Trim();
            Settings.Default["dataInicio"] = dateDataI.Value;
            Settings.Default["dataFinal"] = dateDataF.Value;
            #endregion

            Clicou = true;
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
