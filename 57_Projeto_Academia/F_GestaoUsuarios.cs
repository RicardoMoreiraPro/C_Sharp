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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 100;
            dgv_usuarios.Columns[1].Width = 200;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv =(DataGridView)sender;
            int conslinhas = dgv.SelectedRows.Count;
            if(conslinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME");
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO");
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO");
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
            
        }
    }
}
