using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSoft_SolucaosInovadoras
{
    public partial class pesquisa_relatorio : Form
    {
        public pesquisa_relatorio()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                if (TextBox1.Text.Length == 0)
                {
                    padariarelatoriosBindingSource.Filter = "";
                }
                else
                {
                    padariarelatoriosBindingSource.Filter = string.Format("relat_cd like'%{0}%'", TextBox1.Text);
                }
            }
        }

        private void pesquisa_relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'padariaDataSet.Padaria_relatorios' table. You can move, or remove it, as needed.
            this.padaria_relatoriosTableAdapter.Fill(this.padariaDataSet.Padaria_relatorios);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length == 0)
            {
                MessageBox.Show("Por Favor entre com o Código");
            }
            else
            {
                padariarelatoriosBindingSource.Filter = string.Format("relat_cd={0}", TextBox1.Text);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você deseja alterar o Preço?", "confirmação",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Class1.codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();//
                this.Close();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Você deseja excluir o item?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    try
                {
                    string codigo;
                    codigo = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    padariarelatoriosBindingSource.RemoveCurrent();
                    padaria_relatoriosTableAdapter.Update(padariaDataSet.Padaria_relatorios); //salvar
                    this.padaria_relatoriosTableAdapter.Fill(this.padariaDataSet.Padaria_relatorios);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível excluir registro.\n" + erro.Message.ToString());
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ajudapesquisa janelanova = new ajudapesquisa();
            janelanova.ShowDialog();
            this.Visible = true;
        }
    }
}