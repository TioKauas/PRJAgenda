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
    public partial class Form1 : Form
    {
        Cadastro c = new Cadastro();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Verificação de conteúdo
            //if (txtTituloS.Text == "" && txtDescricaoS.Text == "")
            //{
            //    boxTarefa.Visible = false;
            //    BoxVazio.Visible = true;
            //}
            //else
            //{
            //    boxTarefa.Visible = true;
                BoxVazio.Visible = false;
            //}
            #endregion
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            var Form = new Cadastro();
            Form.Show();

            if (c.Clicou == true)
            {
                txtTituloS.Text = Settings.Default["Titulo"].ToString();
                txtDescricaoS.Text = Settings.Default["Descricao"].ToString();
                dateDataInicialS.Value = DateTime.Parse(Settings.Default["dataInicio"].ToString());
                dateDataFinalS.Value = DateTime.Parse(Settings.Default["dataFinal"].ToString());

                MessageBox.Show("aaa");
            }
        }
    }
}
