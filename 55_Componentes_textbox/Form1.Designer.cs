namespace _55_Componentes_textbox
{
    partial class F_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_listaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_valNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adicionar.Location = new System.Drawing.Point(190, 50);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_veiculo.Location = new System.Drawing.Point(14, 50);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um veiculo";
            // 
            // tb_listaVeiculos
            // 
            this.tb_listaVeiculos.BackColor = System.Drawing.SystemColors.Window;
            this.tb_listaVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_listaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_listaVeiculos.Location = new System.Drawing.Point(14, 79);
            this.tb_listaVeiculos.Multiline = true;
            this.tb_listaVeiculos.Name = "tb_listaVeiculos";
            this.tb_listaVeiculos.ReadOnly = true;
            this.tb_listaVeiculos.Size = new System.Drawing.Size(251, 174);
            this.tb_listaVeiculos.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_limpar.Location = new System.Drawing.Point(14, 259);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(251, 23);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_mostrar.Location = new System.Drawing.Point(17, 288);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(248, 23);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar veiculos";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_valNum
            // 
            this.btn_valNum.BackColor = System.Drawing.Color.Gold;
            this.btn_valNum.Location = new System.Drawing.Point(17, 317);
            this.btn_valNum.Name = "btn_valNum";
            this.btn_valNum.Size = new System.Drawing.Size(248, 23);
            this.btn_valNum.TabIndex = 6;
            this.btn_valNum.Text = "Valor da variavel num";
            this.btn_valNum.UseVisualStyleBackColor = false;
            this.btn_valNum.Click += new System.EventHandler(this.btn_valNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.fComboBoxToolStripMenuItem,
            this.dataTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.toolStripMenuItem1,
            this.radioButtonToolStripMenuItem,
            this.trackBarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // fComboBoxToolStripMenuItem
            // 
            this.fComboBoxToolStripMenuItem.Name = "fComboBoxToolStripMenuItem";
            this.fComboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fComboBoxToolStripMenuItem.Text = "ComboBox";
            this.fComboBoxToolStripMenuItem.Click += new System.EventHandler(this.ComboBoxToolStripMenuItem_Click);
            // 
            // dataTimePickerToolStripMenuItem
            // 
            this.dataTimePickerToolStripMenuItem.Name = "dataTimePickerToolStripMenuItem";
            this.dataTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dataTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dataTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "Label/LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "ProgressBar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "TreeView";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "WebBrowser";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Icone do mau";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_mensagem,
            this.tsmi_fechar});
            this.MenuNotificacoes.Name = "MenuNotificacoes";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.Text = "toolStripMenuItem1";
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_mensagem
            // 
            this.tsmi_mensagem.Name = "tsmi_mensagem";
            this.tsmi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_mensagem.Text = "Mensagem";
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_fechar.Text = "Fechar";
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(277, 363);
            this.Controls.Add(this.btn_valNum);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_listaVeiculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_valNum;
        public System.Windows.Forms.TextBox tb_listaVeiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

