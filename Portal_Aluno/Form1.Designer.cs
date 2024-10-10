namespace Portal_Aluno
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_adicionar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            panel1 = new Panel();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(95, 360);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(120, 32);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(90, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 90);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 180);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 3;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 270);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 4;
            label4.Text = "Curso:";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(30, 115);
            txt_nome.Margin = new Padding(3, 3, 5, 5);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(250, 23);
            txt_nome.TabIndex = 5;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(30, 205);
            txt_idade.Margin = new Padding(3, 3, 5, 5);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(250, 23);
            txt_idade.TabIndex = 6;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(30, 295);
            txt_curso.Margin = new Padding(3, 3, 5, 5);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(250, 23);
            txt_curso.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(300, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 410);
            panel1.TabIndex = 8;
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(10, 82);
            lv_alunos.Margin = new Padding(10, 10, 10, 5);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(365, 315);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 140;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 160;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(10, 30);
            label5.Name = "label5";
            label5.Size = new Size(157, 30);
            label5.TabIndex = 9;
            label5.Text = "Lista de Alunos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(684, 411);
            Controls.Add(panel1);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_adicionar);
            Name = "Form1";
            Text = "Formulário";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Panel panel1;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
    }
}
