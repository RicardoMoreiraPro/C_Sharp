namespace _57_Projeto_Academia
{
    partial class F_Horarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tb_idHorario = new System.Windows.Forms.TextBox();
            this.mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.dgv_horarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 32);
            this.panel1.TabIndex = 4;
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(4, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(118, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Horário";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(128, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(118, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Horário";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(252, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(118, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir horário";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(376, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(118, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // tb_idHorario
            // 
            this.tb_idHorario.Location = new System.Drawing.Point(16, 30);
            this.tb_idHorario.Name = "tb_idHorario";
            this.tb_idHorario.ReadOnly = true;
            this.tb_idHorario.Size = new System.Drawing.Size(71, 20);
            this.tb_idHorario.TabIndex = 5;
            this.tb_idHorario.TabStop = false;
            // 
            // mtb_dscHorario
            // 
            this.mtb_dscHorario.Location = new System.Drawing.Point(118, 29);
            this.mtb_dscHorario.Mask = "99:99 \\até 99:99";
            this.mtb_dscHorario.Name = "mtb_dscHorario";
            this.mtb_dscHorario.Size = new System.Drawing.Size(91, 20);
            this.mtb_dscHorario.TabIndex = 6;
            this.mtb_dscHorario.ValidatingType = typeof(System.DateTime);
            // 
            // dgv_horarios
            // 
            this.dgv_horarios.AllowUserToAddRows = false;
            this.dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_horarios.EnableHeadersVisualStyles = false;
            this.dgv_horarios.Location = new System.Drawing.Point(4, 55);
            this.dgv_horarios.MultiSelect = false;
            this.dgv_horarios.Name = "dgv_horarios";
            this.dgv_horarios.RowHeadersVisible = false;
            this.dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_horarios.Size = new System.Drawing.Size(490, 356);
            this.dgv_horarios.TabIndex = 7;
            this.dgv_horarios.SelectionChanged += new System.EventHandler(this.dgv_horarios_SelectionChanged);
            // 
            // F_Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.dgv_horarios);
            this.Controls.Add(this.mtb_dscHorario);
            this.Controls.Add(this.tb_idHorario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_Horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox tb_idHorario;
        private System.Windows.Forms.MaskedTextBox mtb_dscHorario;
        private System.Windows.Forms.DataGridView dgv_horarios;
    }
}