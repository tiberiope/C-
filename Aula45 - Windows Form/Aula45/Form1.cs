﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_texto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            lb_texto.Text = tb_texto.Text;
        }
    }
}
