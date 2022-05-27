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
    public partial class Form_Veiculos : Form
    {
        Form_Principal fp;
     
        public Form_Veiculos(List<string> v, Form_Principal fp)
        {
            InitializeComponent();

            foreach(string n in v)
            {
                listb_veiculo2.Items.Add(n);
                if (tb_veiculo.Text == "")
                {
                    tb_veiculo.Text = n;
                }
                else
                {
                    tb_veiculo.Text += ", " + n;
                }
            }

            this.fp = fp;
            fp.num = 1;

            /*for (int i = 0; i < v.Count; i++)
            {
                listb_veiculo2.Items.Add(v[i]);
            }*/
        }

        private void Form_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista_veiculo.Text = "Item escolhido: " + listb_veiculo2.SelectedItem.ToString()
                                      + ". Todos os items: " + tb_veiculo.Text;
        }
    }
}
