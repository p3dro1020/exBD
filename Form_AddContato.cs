using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exBD
{
    public partial class Form_AddContato : Form
    {
        public Form_AddContato()
        {
            InitializeComponent();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!");
                return;
            }

            if (txt_num.Text == "")
            {
                MessageBox.Show("Preencha o campo telefone!");
                return;
            }

            Conexao conexao = new Conexao();
            conexao.AdicionarContato(txt_nome.Text, txt_num.Text);
            MessageBox.Show("Contato adicionado com sucesso!");
            this.Close();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_num.Text = "";
            this.Close();
        }
    }
}
