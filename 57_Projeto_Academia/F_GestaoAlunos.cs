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
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"SELECT N_IDALUNO as 'ID', T_NOMEALUNO as 'Aluno' FROM tb_alunos";
            dgv_gestaoAlunos.DataSource = Banco.dql(vqueryDGV);
            dgv_gestaoAlunos.Columns[0].Width = 50;
            dgv_gestaoAlunos.Columns[1].Width= 150;

            tb_nome.Text = dgv_gestaoAlunos.Rows[dgv_gestaoAlunos.SelectedRows[0].Index].Cells[1].Value.ToString();

            //Popular ComboBox Turmas
            string vqueryTurmas = @"
                SELECT N_IDTURMA,
                    ('Vagas: '|| ((N_MAXALUNOS) - (SELECT count(tba.N_IDALUNO) 
                    FROM tb_alunos as tba 
                    WHERE tba.T_STATUS = 'A' and tba.N_IDTURMA = N_IDTURMA)) || 
                    ' / Turma: ' || T_DSCTURMA) as 'Turma' 
                    FROM tb_turmas 
                    ORDER BY N_IDTURMA ";
            cb_turmas.Items.Clear();
            cb_turmas.DataSource = Banco.dql(vqueryTurmas);
            cb_turmas.DisplayMember = "Turma";
            cb_turmas.ValueMember = "N_IDTURMA";

            //Popular ComboBox Status ("Ativo = A, Bloqueado = B, Cancelado = C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            turma = cb_turmas.Text;
            turmaAtual = cb_turmas.Text;
            idSelecionado = dgv_gestaoAlunos.Rows[0].Cells[0].Value.ToString();
        }
    }
}
