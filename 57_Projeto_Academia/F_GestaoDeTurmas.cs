using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace _57_Projeto_Academia
{
    public partial class F_GestaoDeTurmas : Form
    {
        string idSelecionado;
        public F_GestaoDeTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoDeTurmas_Load(object sender, EventArgs e)
        {
            string vquery = @"select
                    t.N_IDTURMA as 'ID Turma',
                    t.T_DSCTURMA as 'Turma',
                    p.T_NOMEPROFESSOR as 'Professor',
                    h.T_DSCHORARIO as 'Horario',
                    t.N_MAXALUNOS as 'Maximo de alunos',
                case
                    when t.T_STATUS = 'A' then 'ATIVA'
                    when t.T_STATUS = 'P' then 'PARALISADA'
                    when t.T_STATUS = 'C' then 'CANCELADA'
                end as 'Status'
                from tb_turmas as t
                inner join 
                    tb_professores as p on t.N_IDPROFESSOR = p.N_IDPROFESSOR, 
                    tb_horarios as h on t.N_IDHORARIO = h.N_IDHORARIO";
            dgv_turmas.DataSource = Banco.dql(vquery);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 80;
            dgv_turmas.Columns[2].Width = 100;
            dgv_turmas.Columns[3].Width = 100;
            dgv_turmas.Columns[4].Width = 60;

            string vqueryProfessores = "select N_IDPROFESSOR, T_NOMEPROFESSOR from tb_professores order by N_IDPROFESSOR";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource (st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            string vqueryHorarios = "select * from tb_horarios order by T_DSCHORARIO";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";
        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"select T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS from tb_turmas where N_IDTURMA=" + idSelecionado;
                DataTable dt = new DataTable();
                dt = Banco.dql(vqueryCampos);
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                nud_maximoAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
            }
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            nud_maximoAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;
            string queryAtualizarTurma = String.Format(@"
                update tb_turmas set T_DSCTURMA = '{0}', N_IDPROFESSOR = {1},
                    N_IDHORARIO = {2}, N_MAXALUNOS = {3}, T_STATUS = '{4}'
                    where N_IDTURMA= {5}", tb_dscTurma.Text, cb_professor.SelectedValue,
                    cb_horario.SelectedValue, Int32.Parse(Math.Round(nud_maximoAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
            Banco.dml(queryAtualizarTurma);
            dgv_turmas[1, linha].Value = tb_dscTurma.Text;
            dgv_turmas[2, linha].Value = cb_professor.Text;
            dgv_turmas[3, linha].Value = cb_horario.Text;
            dgv_turmas[4, linha].Value = nud_maximoAlunos.Value;
            dgv_turmas[5, linha].Value = cb_status.Text;
            MessageBox.Show("Dados gravados");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"DELETE FROM tb_turmas WHERE N_IDTURMA= {0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
            
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
