namespace ProjetoForm1
{
    partial class Atividade1
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_palavra = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btn_movedir = new System.Windows.Forms.Button();
            this.btn_movetudodir = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_moveesq = new System.Windows.Forms.Button();
            this.btn_movetudoesq = new System.Windows.Forms.Button();
            this.btn_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(16, 208);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(156, 292);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(457, 155);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 28);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palavra";
            // 
            // txt_palavra
            // 
            this.txt_palavra.Location = new System.Drawing.Point(132, 158);
            this.txt_palavra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_palavra.Name = "txt_palavra";
            this.txt_palavra.Size = new System.Drawing.Size(293, 22);
            this.txt_palavra.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(400, 208);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(156, 292);
            this.lb2.TabIndex = 6;
            // 
            // btn_movedir
            // 
            this.btn_movedir.Location = new System.Drawing.Point(237, 271);
            this.btn_movedir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_movedir.Name = "btn_movedir";
            this.btn_movedir.Size = new System.Drawing.Size(100, 28);
            this.btn_movedir.TabIndex = 7;
            this.btn_movedir.Text = ">";
            this.btn_movedir.UseVisualStyleBackColor = true;
            this.btn_movedir.Click += new System.EventHandler(this.btn_movedir_Click);
            // 
            // btn_movetudodir
            // 
            this.btn_movetudodir.Location = new System.Drawing.Point(237, 208);
            this.btn_movetudodir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_movetudodir.Name = "btn_movetudodir";
            this.btn_movetudodir.Size = new System.Drawing.Size(100, 28);
            this.btn_movetudodir.TabIndex = 8;
            this.btn_movetudodir.Text = ">>";
            this.btn_movetudodir.UseVisualStyleBackColor = true;
            this.btn_movetudodir.Click += new System.EventHandler(this.btn_movetudodir_Click);
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(237, 336);
            this.btn_move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(100, 28);
            this.btn_move.TabIndex = 9;
            this.btn_move.Text = "Novo";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_moveesq
            // 
            this.btn_moveesq.Location = new System.Drawing.Point(237, 405);
            this.btn_moveesq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_moveesq.Name = "btn_moveesq";
            this.btn_moveesq.Size = new System.Drawing.Size(100, 28);
            this.btn_moveesq.TabIndex = 10;
            this.btn_moveesq.Text = "<";
            this.btn_moveesq.UseVisualStyleBackColor = true;
            this.btn_moveesq.Click += new System.EventHandler(this.btn_moveesq_Click);
            // 
            // btn_movetudoesq
            // 
            this.btn_movetudoesq.Location = new System.Drawing.Point(237, 473);
            this.btn_movetudoesq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_movetudoesq.Name = "btn_movetudoesq";
            this.btn_movetudoesq.Size = new System.Drawing.Size(100, 28);
            this.btn_movetudoesq.TabIndex = 11;
            this.btn_movetudoesq.Text = "<<";
            this.btn_movetudoesq.UseVisualStyleBackColor = true;
            this.btn_movetudoesq.Click += new System.EventHandler(this.btn_movetudoesq_Click);
            // 
            // btn_prox
            // 
            this.btn_prox.Location = new System.Drawing.Point(16, 15);
            this.btn_prox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(100, 28);
            this.btn_prox.TabIndex = 12;
            this.btn_prox.Text = "Voltar";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.btn_prox_Click);
            // 
            // Atividade1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 554);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.btn_movetudoesq);
            this.Controls.Add(this.btn_moveesq);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.btn_movetudodir);
            this.Controls.Add(this.btn_movedir);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txt_palavra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Atividade1";
            this.Text = "Atividade 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_palavra;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btn_movedir;
        private System.Windows.Forms.Button btn_movetudodir;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_moveesq;
        private System.Windows.Forms.Button btn_movetudoesq;
        private System.Windows.Forms.Button btn_prox;
    }
}

