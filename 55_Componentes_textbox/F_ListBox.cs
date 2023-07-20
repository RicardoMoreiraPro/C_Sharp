using System;
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
    public partial class F_ListBox : Form
    {
        public void atualizar(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }
        List <string> carros = new List <string> ();

        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("Hrv");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                tb_carro.Focus ();
                atualizar(lb_carros, carros);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizar(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizar(lb_carros, carros);
        }
    }
}
