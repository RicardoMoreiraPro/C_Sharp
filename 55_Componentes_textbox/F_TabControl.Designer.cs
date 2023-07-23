namespace _55_Componentes_textbox
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_nomeNovaTab = new System.Windows.Forms.TextBox();
            this.btn_novaTab = new System.Windows.Forms.Button();
            this.btn_removerTabAtual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_PosicionarTab = new System.Windows.Forms.Button();
            this.tab_componentes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tab_componentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tb_nomeNovaTab
            // 
            this.tb_nomeNovaTab.Location = new System.Drawing.Point(16, 13);
            this.tb_nomeNovaTab.Name = "tb_nomeNovaTab";
            this.tb_nomeNovaTab.Size = new System.Drawing.Size(116, 20);
            this.tb_nomeNovaTab.TabIndex = 1;
            // 
            // btn_novaTab
            // 
            this.btn_novaTab.Location = new System.Drawing.Point(159, 9);
            this.btn_novaTab.Name = "btn_novaTab";
            this.btn_novaTab.Size = new System.Drawing.Size(106, 23);
            this.btn_novaTab.TabIndex = 2;
            this.btn_novaTab.Text = "Nova Tab";
            this.btn_novaTab.UseVisualStyleBackColor = true;
            this.btn_novaTab.Click += new System.EventHandler(this.btn_novaTab_Click);
            // 
            // btn_removerTabAtual
            // 
            this.btn_removerTabAtual.Location = new System.Drawing.Point(271, 9);
            this.btn_removerTabAtual.Name = "btn_removerTabAtual";
            this.btn_removerTabAtual.Size = new System.Drawing.Size(103, 23);
            this.btn_removerTabAtual.TabIndex = 3;
            this.btn_removerTabAtual.Text = "Remover Tab Atual";
            this.btn_removerTabAtual.UseVisualStyleBackColor = true;
            this.btn_removerTabAtual.Click += new System.EventHandler(this.btn_removerTabAtual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_PosicionarTab
            // 
            this.btn_PosicionarTab.Location = new System.Drawing.Point(159, 39);
            this.btn_PosicionarTab.Name = "btn_PosicionarTab";
            this.btn_PosicionarTab.Size = new System.Drawing.Size(106, 23);
            this.btn_PosicionarTab.TabIndex = 5;
            this.btn_PosicionarTab.Text = "Posicionar na Tab";
            this.btn_PosicionarTab.UseVisualStyleBackColor = true;
            this.btn_PosicionarTab.Click += new System.EventHandler(this.btn_PosicionarTab_Click);
            // 
            // tab_componentes
            // 
            this.tab_componentes.Controls.Add(this.button1);
            this.tab_componentes.Controls.Add(this.textBox1);
            this.tab_componentes.Controls.Add(this.label1);
            this.tab_componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_componentes.Name = "tab_componentes";
            this.tab_componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_componentes.Size = new System.Drawing.Size(710, 344);
            this.tab_componentes.TabIndex = 0;
            this.tab_componentes.Text = "Componentes";
            this.tab_componentes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.btn_PosicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTabAtual);
            this.Controls.Add(this.btn_novaTab);
            this.Controls.Add(this.tb_nomeNovaTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tab_componentes.ResumeLayout(false);
            this.tab_componentes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_componentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_nomeNovaTab;
        private System.Windows.Forms.Button btn_novaTab;
        private System.Windows.Forms.Button btn_removerTabAtual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_PosicionarTab;
    }
}