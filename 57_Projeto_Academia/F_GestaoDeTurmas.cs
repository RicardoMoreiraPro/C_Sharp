using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
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
        int modo = 0;    //0 = Padrão   1 = Edição   2 = Inserção
        string vquery;
        public F_GestaoDeTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoDeTurmas_Load(object sender, EventArgs e)
        {
            vquery = @"select
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
                modo = 0;
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"select T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS from tb_turmas where N_IDTURMA=" + idSelecionado;
                DataTable dt = new DataTable();
                dt = Banco.dql(vqueryCampos);
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                nud_maximoAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                tb_vagas.Text = calcVagas();
            }
        }
        private string calcVagas()
        {
            //Calculo de vagas
            string queryVagas = String.Format(@" select count(N_IDALUNO) as 'contVagas' from tb_alunos where T_STATUS = 'A' and N_IDTURMA = {0}", idSelecionado);
            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(nud_maximoAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            return vagas.ToString();
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            nud_maximoAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            tb_dscTurma.Focus();
            modo = 2;
        }
        
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            if (modo != 0)
            {
                string queryTurma = "";
                string msg = "";
                int linha = dgv_turmas.SelectedRows[0].Index;
                if (modo == 1)
                {
                    msg = "Dados alterados";
                    queryTurma = String.Format(@" update tb_turmas set T_DSCTURMA = '{0}', N_IDPROFESSOR = {1}, N_IDHORARIO = {2}, N_MAXALUNOS = {3}, T_STATUS = '{4}' where N_IDTURMA= {5}", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nud_maximoAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
                    tb_vagas.Text = calcVagas();
                }
                else
                {
                    msg = ("Nova turma inserida");
                    queryTurma = String.Format(@" insert into tb_turmas (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) values ('{0}',{1},{2},{3},'{4}')", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(nud_maximoAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                    
                }
                
                Banco.dml(queryTurma);
                if (modo == 1)
                {
                    dgv_turmas[1, linha].Value = tb_dscTurma.Text;
                    dgv_turmas[2, linha].Value = cb_professor.Text;
                    dgv_turmas[3, linha].Value = cb_horario.Text;
                    dgv_turmas[4, linha].Value = nud_maximoAlunos.Value;
                    dgv_turmas[5, linha].Value = cb_status.Text;
                }
                else
                {
                    dgv_turmas.DataSource = Banco.dql(vquery);
                }
                    MessageBox.Show(msg);
            }
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

        private void tb_dscTurma_TextChanged(object sender, EventArgs e)
        {
            if (modo == 0) 
            {
                modo = 1;
            }
        }

        private void cb_professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void nud_maximoAlunos_ValueChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cb_horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\arvore.jpg");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_CENTER;
            //logo.SetAbsolutePosition(100f, 500f);  //X, -Y
            
            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_LEFT;
            paragrafo1.Add("PDF RICARDO MOREIRA\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("RICARDO MOREIRA\n");
            string texto = "youtube.com/cfbcursos";
            paragrafo1.Add(texto + "\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_LEFT;
            texto = "Este é o texto do segundo paragrafo";
            paragrafo2.Add(texto + "\n\n\n");

            
            PdfPTable tabela = new PdfPTable(3); //3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            PdfPCell celula1 = new PdfPCell();
            celula1.Colspan = 3; //Linha 1 mesclada
            //celula.Rotation = 90;
            celula1.AddElement(logo);
            tabela.AddCell(celula1);

            tabela.AddCell("Código");
            tabela.AddCell("Produto");
            tabela.AddCell("Preço");

            tabela.AddCell("01");
            tabela.AddCell("Mouse");
            tabela.AddCell("25,00");

            tabela.AddCell("02");
            tabela.AddCell("Teclado");
            tabela.AddCell("65,00");

            PdfPCell celula2 = new PdfPCell(new Phrase("Tabela de preços"));
            celula2.Rotation = 0;
            celula2.Colspan = 3; ////Linha 1 mesclada
            celula2.FixedHeight = 40;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela.AddCell(celula2);

            Paragraph paragrafo3 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo3.Alignment = Element.ALIGN_CENTER;
            texto = "Relatório de Turmas";
            paragrafo3.Add(texto + "\n\n");

            PdfPTable tabela2 = new PdfPTable(3); //3 colunas
            tabela2.DefaultCell.FixedHeight = 20;

            tabela2.AddCell("ID Turma");
            tabela2.AddCell("Turma");
            tabela2.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vquery);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela2.AddCell(dtTurmas.Rows[i].Field<Int64>("ID Turma").ToString());
                tabela2.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela2.AddCell(dtTurmas.Rows[i].Field<string>("Horario"));
            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(tabela);
            doc.Add(paragrafo3);
            doc.Add(tabela2);
            doc.Close();

            DialogResult res = MessageBox.Show("Deseja abrir o Relatório?", "Relatório", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
            }
        }
    }
}
