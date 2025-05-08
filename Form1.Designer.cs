namespace AULA09
{
    partial class Form1
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Deletar = new System.Windows.Forms.Button();
            this.list_clientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(31, 52);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(38, 13);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(158, 52);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(38, 13);
            this.lb_email.TabIndex = 0;
            this.lb_email.Text = "E-mail:";
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.Location = new System.Drawing.Point(290, 52);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(37, 13);
            this.lb_idade.TabIndex = 0;
            this.lb_idade.Text = "Idade:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(34, 68);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(161, 68);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 2;
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(293, 68);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(100, 20);
            this.tb_idade.TabIndex = 3;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(34, 106);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(359, 23);
            this.bt_Salvar.TabIndex = 4;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Location = new System.Drawing.Point(34, 135);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(359, 23);
            this.bt_Atualizar.TabIndex = 5;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            // 
            // bt_Deletar
            // 
            this.bt_Deletar.Location = new System.Drawing.Point(34, 356);
            this.bt_Deletar.Name = "bt_Deletar";
            this.bt_Deletar.Size = new System.Drawing.Size(359, 23);
            this.bt_Deletar.TabIndex = 6;
            this.bt_Deletar.Text = "Deletar";
            this.bt_Deletar.UseVisualStyleBackColor = true;
            this.bt_Deletar.Click += new System.EventHandler(this.bt_Deletar_Click);
            // 
            // list_clientes
            // 
            this.list_clientes.FormattingEnabled = true;
            this.list_clientes.Location = new System.Drawing.Point(34, 164);
            this.list_clientes.Name = "list_clientes";
            this.list_clientes.Size = new System.Drawing.Size(359, 186);
            this.list_clientes.TabIndex = 7;
            this.list_clientes.SelectedIndexChanged += new System.EventHandler(this.list_clientes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.list_clientes);
            this.Controls.Add(this.bt_Deletar);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Deletar;
        private System.Windows.Forms.ListBox list_clientes;
    }
}

