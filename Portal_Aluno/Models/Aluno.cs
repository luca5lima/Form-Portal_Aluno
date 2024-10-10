using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Aluno.Models
{
    public class Aluno
    {
        public Aluno(string nome, int idade, string curso)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }
    }
}
