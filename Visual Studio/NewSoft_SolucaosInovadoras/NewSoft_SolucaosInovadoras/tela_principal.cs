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
    public partial class tela_principal : Form
    {
       
        public tela_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Você deseja sair do Sistema?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Login janelanova = new Login();
                janelanova.ShowDialog();
            }

                //this.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastrar_funcionario janelanova = new Cadastrar_funcionario();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro_cliente janelanova = new Cadastro_cliente();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro_fornecedor janelanova = new Cadastro_fornecedor();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           Cadastro_produto janelanova = new Cadastro_produto();
            janelanova.ShowDialog();
            this.Visible = true;
          
        }

        private void encomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Encomenda janelanova = new Encomenda();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            estoque janelanova = new estoque();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backupERestaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            caixa janelanova = new caixa();
            janelanova.ShowDialog();
            this.Visible = true;
          
        }

        private void preçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            preço janelanova = new preço();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Relatorio1 janelanova = new Relatorio1();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void retiradaDeEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registroDeEncomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Encomenda janelanova = new Encomenda();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login janelanova = new Login();
            janelanova.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Login janelanova = new Login();
            janelanova.ShowDialog();
        }

        private void backupERestauracãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tela_backup janelanova = new tela_backup();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sobre janelanova = new Sobre();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ajuda janelanova = new ajuda();
            janelanova.ShowDialog();
            this.Visible = true;
        }

        private void tela_principal_Resize(object sender, EventArgs e)
        {
      

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair do Sistema?", "Confirmação",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Login janelanova = new Login();
                janelanova.ShowDialog();
            }

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
