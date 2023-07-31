namespace _57_Projeto_Academia
{
    partial class F_Gestao_De_Professores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_idprofessor = new System.Windows.Forms.TextBox();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.tb_nomeProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Professor";
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(4, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(118, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Professor";
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
            this.btn_salvar.Text = "Salvar Professor";
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
            this.btn_excluir.Text = "Excluir Professor";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 32);
            this.panel1.TabIndex = 10;
            // 
            // tb_idprofessor
            // 
            this.tb_idprofessor.Location = new System.Drawing.Point(16, 24);
            this.tb_idprofessor.Name = "tb_idprofessor";
            this.tb_idprofessor.ReadOnly = true;
            this.tb_idprofessor.Size = new System.Drawing.Size(71, 20);
            this.tb_idprofessor.TabIndex = 11;
            this.tb_idprofessor.TabStop = false;
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            this.dgv_professores.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.EnableHeadersVisualStyles = false;
            this.dgv_professores.Location = new System.Drawing.Point(4, 49);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.RowHeadersVisible = false;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(490, 356);
            this.dgv_professores.TabIndex = 13;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // tb_nomeProfessor
            // 
            this.tb_nomeProfessor.Location = new System.Drawing.Point(107, 23);
            this.tb_nomeProfessor.Name = "tb_nomeProfessor";
            this.tb_nomeProfessor.Size = new System.Drawing.Size(228, 20);
            this.tb_nomeProfessor.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(350, 23);
            this.mtb_telefone.Mask = "(00)99999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(144, 20);
            this.mtb_telefone.TabIndex = 16;
            // 
            // F_Gestao_De_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nomeProfessor);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.tb_idprofessor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Gestao_De_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_Gestao_De_Professores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_idprofessor;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.TextBox tb_nomeProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
    }
}