using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_Projeto_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login1 = new F_Login(this);
            f_Login1.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "...";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Globais.logado)
            {
                if(Globais.nivel >=2)
                { //Procedimentos da tabela
                    
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                { //Procedimentos da tabela
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                { //Procedimentos da tabela
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            { //Procedimentos da tabela

            }
            else
            {
                MessageBox.Show("É necessario ter um usuario logado");
            }
        }
    }
}
