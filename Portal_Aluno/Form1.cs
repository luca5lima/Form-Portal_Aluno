using Portal_Aluno.Models;

namespace Portal_Aluno
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; private set; } = new List<Aluno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = txt_nome.Text;
                var idade = txt_idade.Text;
                var curso = txt_curso.Text;

                foreach (var item in Alunos)
                {
                    if (item.Nome == nome)
                    {
                        MessageBox.Show(nome + "já está cadastrado no sistema");
                        return;
                    }
                }

                var aluno = new Aluno(nome, idade, curso);
                Alunos.Add(aluno);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
