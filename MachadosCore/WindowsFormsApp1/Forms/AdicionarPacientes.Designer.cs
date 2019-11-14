namespace WindowsFormsApp1.Forms
{
    partial class AdicionarPacientes
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
            this.AdicionarClienteBotao = new System.Windows.Forms.Button();
            this.DataDaPrimeriaConsulta = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.HorarioTextBox = new System.Windows.Forms.TextBox();
            this.PlanoTextBox = new System.Windows.Forms.TextBox();
            this.DiaDaSemanaTextBox = new System.Windows.Forms.TextBox();
            this.CpfTextBox = new System.Windows.Forms.TextBox();
            this.RgTextBox = new System.Windows.Forms.TextBox();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdicionarClienteBotao
            // 
            this.AdicionarClienteBotao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdicionarClienteBotao.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AdicionarClienteBotao.Location = new System.Drawing.Point(310, 125);
            this.AdicionarClienteBotao.Name = "AdicionarClienteBotao";
            this.AdicionarClienteBotao.Size = new System.Drawing.Size(110, 58);
            this.AdicionarClienteBotao.TabIndex = 22;
            this.AdicionarClienteBotao.Text = "Adicionar Clientes";
            this.AdicionarClienteBotao.UseVisualStyleBackColor = false;
            this.AdicionarClienteBotao.Click += new System.EventHandler(this.AdicionarClienteBotao_Click);
            // 
            // DataDaPrimeriaConsulta
            // 
            this.DataDaPrimeriaConsulta.Location = new System.Drawing.Point(27, 471);
            this.DataDaPrimeriaConsulta.Name = "DataDaPrimeriaConsulta";
            this.DataDaPrimeriaConsulta.Size = new System.Drawing.Size(240, 20);
            this.DataDaPrimeriaConsulta.TabIndex = 21;
            this.DataDaPrimeriaConsulta.Text = "Pao";
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(27, 276);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(240, 20);
            this.ValorTextBox.TabIndex = 20;
            // 
            // HorarioTextBox
            // 
            this.HorarioTextBox.Location = new System.Drawing.Point(27, 378);
            this.HorarioTextBox.Name = "HorarioTextBox";
            this.HorarioTextBox.Size = new System.Drawing.Size(240, 20);
            this.HorarioTextBox.TabIndex = 19;
            // 
            // PlanoTextBox
            // 
            this.PlanoTextBox.Location = new System.Drawing.Point(27, 427);
            this.PlanoTextBox.Name = "PlanoTextBox";
            this.PlanoTextBox.Size = new System.Drawing.Size(240, 20);
            this.PlanoTextBox.TabIndex = 18;
            // 
            // DiaDaSemanaTextBox
            // 
            this.DiaDaSemanaTextBox.Location = new System.Drawing.Point(27, 325);
            this.DiaDaSemanaTextBox.Name = "DiaDaSemanaTextBox";
            this.DiaDaSemanaTextBox.Size = new System.Drawing.Size(240, 20);
            this.DiaDaSemanaTextBox.TabIndex = 17;
            this.DiaDaSemanaTextBox.Text = "Colocar -Feira";
            // 
            // CpfTextBox
            // 
            this.CpfTextBox.Location = new System.Drawing.Point(27, 220);
            this.CpfTextBox.Name = "CpfTextBox";
            this.CpfTextBox.Size = new System.Drawing.Size(240, 20);
            this.CpfTextBox.TabIndex = 16;
            // 
            // RgTextBox
            // 
            this.RgTextBox.Location = new System.Drawing.Point(27, 170);
            this.RgTextBox.Name = "RgTextBox";
            this.RgTextBox.Size = new System.Drawing.Size(240, 20);
            this.RgTextBox.TabIndex = 15;
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(27, 125);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(240, 20);
            this.NomeTextBox.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(310, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 290);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 24;
            this.button1.Text = "Gerar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "Adicionar Pacientes e Tabela";
            // 
            // btnTabela
            // 
            this.btnTabela.Location = new System.Drawing.Point(572, 125);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(108, 58);
            this.btnTabela.TabIndex = 26;
            this.btnTabela.Text = "Tabela de Horarios ";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // AdicionarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AdicionarClienteBotao);
            this.Controls.Add(this.DataDaPrimeriaConsulta);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.HorarioTextBox);
            this.Controls.Add(this.PlanoTextBox);
            this.Controls.Add(this.DiaDaSemanaTextBox);
            this.Controls.Add(this.CpfTextBox);
            this.Controls.Add(this.RgTextBox);
            this.Controls.Add(this.NomeTextBox);
            this.Name = "AdicionarPacientes";
            this.Text = "AdicionarPacientes";
            this.Load += new System.EventHandler(this.AdicionarPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdicionarClienteBotao;
        private System.Windows.Forms.TextBox DataDaPrimeriaConsulta;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox HorarioTextBox;
        private System.Windows.Forms.TextBox PlanoTextBox;
        private System.Windows.Forms.TextBox DiaDaSemanaTextBox;
        private System.Windows.Forms.TextBox CpfTextBox;
        private System.Windows.Forms.TextBox RgTextBox;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTabela;
    }
}