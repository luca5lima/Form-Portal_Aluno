namespace Portal_Aluno
{
    public partial class Form1 : Form
    {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
