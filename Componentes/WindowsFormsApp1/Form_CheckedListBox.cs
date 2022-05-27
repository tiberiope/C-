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
    public partial class Form_CheckedListBox : Form
    {
        static CheckedListBox clb = new CheckedListBox();
        public Form_CheckedListBox()
        {
            InitializeComponent();

            clb.Items.AddRange(clb_transp.Items);
        }

        private void btn_transp_limpar_lista_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();
        }

        private void btn_transp_resetar_lista_Click(object sender, EventArgs e)
        {
            clb_transp.Items.Clear();
            clb_transp.Items.AddRange(clb.Items);
        }

        private void btn_transp_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_transp.Text != "")
            {
                if (clb_transp.Items.Contains(tb_transp.Text))
                {
                    MessageBox.Show("Item já existe.");
                }
                else
                {
                    clb_transp.Items.Add(tb_transp.Text);
                    tb_transp.Clear();
                }
            }
            else
            {
                MessageBox.Show("Digite um transporte.");
                tb_transp.Focus();
            }
        }

        private void btn_transp_clb_Click(object sender, EventArgs e)
        {
            string txt = "";

            for(int i=0; i < clb_transp.CheckedItems.Count; i++)
            {
                if (txt == "")
                {
                    txt = clb_transp.CheckedItems[i].ToString();
                }
                else
                {
                    txt += ", " + clb_transp.CheckedItems[i].ToString();
                }
                
            }
            if (txt != "")
            {
                txt += ".";
                MessageBox.Show(txt);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.");
            }
        }
    }
}
