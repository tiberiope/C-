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
    public partial class Form_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();

        public Form_CheckBox()
        {
            InitializeComponent();

            transp.Add(cb_carro);
            transp.Add(cb_moto);
            transp.Add(cb_bicicleta);
            transp.Add(cb_aviao);
            transp.Add(cb_patinete);
        }

        private void btn_transp_marcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox c in transp)
            {
                if (c.Checked)
                {
                    if (txt == "")
                    {
                        txt = c.Text;
                    }
                    else
                    {
                        txt += ", " + c.Text;
                    }
                }
            }

            tb_transportes.Text = txt;
            tb_transportes.Visible = true;
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcado.");
            }
        }

        private void btn_form_filho_Click(object sender, EventArgs e)
        {
            Form_CheckBoxFilho form_CheckBoxFilho = new Form_CheckBoxFilho();
            form_CheckBoxFilho.ShowDialog();
        }
    }
}
