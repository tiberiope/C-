using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Principal : Form
    {
        public int num;
        static List<string> v = new List<string>();
        string mensagem_veiculo_vazio = "Digite um veículo.";
        public Form_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_veiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_lista_veiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text== "")
            {
                MessageBox.Show(mensagem_veiculo_vazio);
                tb_veiculo.Focus();
                
                return;
            }
           
            listb_veiculo.Items.Add(tb_veiculo.Text);
            v.Add(tb_veiculo.Text);
           
            if (tb_lista_veiculo.Text == "")
            {
                tb_lista_veiculo.Text = tb_veiculo.Text;
            }
            else
            {
                tb_lista_veiculo.Text += ", " + tb_veiculo.Text;
            }
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista_veiculo.Clear();
            listb_veiculo.Items.Clear();
            listb_veiculo.Visible = false;
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_veiculo_Click(object sender, EventArgs e)
        {
            if(tb_lista_veiculo.Text == "")
            {
                MessageBox.Show(mensagem_veiculo_vazio);
                tb_veiculo.Focus();

                return;
            }
            listb_veiculo.Visible = true;
            Form_Veiculos form_Veiculos = new Form_Veiculos(v, this);
            form_Veiculos.ShowDialog();
        }

        private void btn_vnum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckBox form_CheckBox = new Form_CheckBox();
            form_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CheckedListBox form_CheckedListBox = new Form_CheckedListBox();
            form_CheckedListBox.ShowDialog();
        }
    }
}
