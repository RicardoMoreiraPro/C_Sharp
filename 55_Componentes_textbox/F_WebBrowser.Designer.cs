namespace _55_Componentes_textbox
{
    partial class F_WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_ir = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_definirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 99);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 351);
            this.webBrowser1.TabIndex = 0;
            // 
            // tb_url
            // 
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_url.Location = new System.Drawing.Point(13, 13);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(758, 20);
            this.tb_url.TabIndex = 1;
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
            // 
            // btn_ir
            // 
            this.btn_ir.Location = new System.Drawing.Point(13, 40);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(185, 23);
            this.btn_ir.TabIndex = 2;
            this.btn_ir.Text = "Ir";
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_ir_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(204, 40);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(185, 23);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(395, 39);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(185, 23);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(586, 40);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(185, 23);
            this.btn_proximo.TabIndex = 5;
            this.btn_proximo.Text = "Proximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(13, 70);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(185, 23);
            this.btn_parar.TabIndex = 6;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(204, 70);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(185, 23);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(395, 70);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(185, 23);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_definirHome
            // 
            this.btn_definirHome.Location = new System.Drawing.Point(586, 70);
            this.btn_definirHome.Name = "btn_definirHome";
            this.btn_definirHome.Size = new System.Drawing.Size(185, 23);
            this.btn_definirHome.TabIndex = 9;
            this.btn_definirHome.Text = "Definir Home";
            this.btn_definirHome.UseVisualStyleBackColor = true;
            this.btn_definirHome.Click += new System.EventHandler(this.btn_definirHome_Click);
            // 
            // F_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.btn_definirHome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.webBrowser1);
            this.Name = "F_WebBrowser";
            this.Text = "F_WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_definirHome;
    }
}