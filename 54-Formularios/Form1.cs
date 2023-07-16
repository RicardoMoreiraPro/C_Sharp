using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54_Formularios
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        private void lb_texto_Click(object sender, EventArgs e)
        {

        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            /*string txt;
            txt = tb_texto.Text;
            lb_texto.Text = txt;*/      
            //ou
            lb_texto.Text = tb_texto.Text;

        }
    }
}
