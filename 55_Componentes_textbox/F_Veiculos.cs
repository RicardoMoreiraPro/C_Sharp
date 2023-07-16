﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _55_Componentes_textbox
{
    public partial class F_Veiculos : Form
    {
        F_principal fp;
      public F_Veiculos(string v, F_principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;
            fp = f;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
