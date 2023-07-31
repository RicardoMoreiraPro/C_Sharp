using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57_Projeto_Academia
{
    public partial class F_Gestao_De_Professores : Form
    {
        public F_Gestao_De_Professores()
        {
            InitializeComponent();
        }

        private void F_Gestao_De_Professores_Load(object sender, EventArgs e)
        {
            string vquery = "select N_IDPROFESSOR as 'ID', T_NOMEPROFESSOR as 'PROFESSOR', T_TELEFONE as 'TELEFONE' from tb_professores order by N_IDPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquery);
            dgv_professores.Columns[0].Width = 50;
            dgv_professores.Columns[1].Width = 200;
            dgv_professores.Columns[2].Width = 150;

        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = "select * from tb_professores where N_IDPROFESSOR=" + vid;
                dt = Banco.dql(vquery);
                tb_idprofessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_nomeProfessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_idprofessor.Clear();
            tb_nomeProfessor.Clear();
            mtb_telefone.Clear();
            tb_nomeProfessor.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if(tb_idprofessor.Text == "")
            {
                vquery = "insert into tb_professores(T_NOMEPROFESSOR, T_TELEFONE) Values('"+tb_nomeProfessor.Text+"','"+mtb_telefone.Text+"')";
            }
            else
            {
                vquery= "update tb_professores set T_NOMEPROFESSOR = '" + tb_nomeProfessor.Text + "', T_TELEFONE = '" + mtb_telefone.Text + "' where N_IDPROFESSOR= " + tb_idprofessor.Text;
            }
            Banco.dml(vquery);
            vquery = "select N_IDPROFESSOR as 'ID', T_NOMEPROFESSOR as 'PROFESSOR', T_TELEFONE as 'TELEFONE' from tb_professores order by N_IDPROFESSOR";
            dgv_professores.DataSource = Banco.dql(vquery);

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma a exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string vquery = "delete from tb_professores where N_IDPROFESSOR= " + tb_idprofessor.Text;
                Banco.dml(vquery);
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
