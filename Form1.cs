
using System.Data;

namespace exBD
{
    public partial class Form1 : Form
    {
        Conexao conexao = new Conexao();
        Form_AddContato form_add = new Form_AddContato();
        public Form1()
        {
            InitializeComponent();
            dgv_contatos.DataSource = conexao.AtualizarDGV();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            form_add.ShowDialog();
            dgv_contatos.DataSource = conexao.AtualizarDGV();
        }

        private void dgv_contatos_SelectionChanged(object sender, EventArgs e)
        {
            txt_nome.Text = dgv_contatos.CurrentRow.Cells[1].Value.ToString();
            txt_num.Text = dgv_contatos.CurrentRow.Cells[2].Value.ToString();
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            // envia um dialogo de confirmação
            if (MessageBox.Show("Deseja realmente remover este contato?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conexao.RemoverContato(int.Parse(dgv_contatos.CurrentRow.Cells[0].Value.ToString()));
                dgv_contatos.DataSource = conexao.AtualizarDGV();
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            // verifica se o usuario alterou algum campo
            if (txt_nome.Text != dgv_contatos.CurrentRow.Cells[1].Value.ToString() || txt_num.Text != dgv_contatos.CurrentRow.Cells[2].Value.ToString())
            {
                // envia um dialogo de confirmação
                if (MessageBox.Show("Deseja realmente alterar este contato?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conexao.AlterarContato(int.Parse(dgv_contatos.CurrentRow.Cells[0].Value.ToString()), txt_nome.Text, txt_num.Text);
                    dgv_contatos.DataSource = conexao.AtualizarDGV();
                }
            }
        }
    }
}
