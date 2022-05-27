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
    public partial class Form_CheckBoxFilho : Form
    { 
        public Form_CheckBox form_CheckBox;
        public Form_CheckBoxFilho()
        {
            InitializeComponent();

            try
            {
                form_CheckBox = Application.OpenForms["Form_CheckBox"] as Form_CheckBox;
                cb_carro.Checked = form_CheckBox.cb_carro.Checked;
                cb_aviao.Checked = form_CheckBox.cb_aviao.Checked;
                cb_bicicleta.Checked = form_CheckBox.cb_bicicleta.Checked;
                cb_moto.Checked = form_CheckBox.cb_moto.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir formulário.");
            }
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_carro.Checked = cb_carro.Checked;
            
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_moto_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_moto.Checked = cb_moto.Checked;
        }

        private void cb_bicicleta_CheckedChanged(object sender, EventArgs e)
        {
            form_CheckBox.cb_bicicleta.Checked = cb_bicicleta.Checked;   
        }
    }
}
