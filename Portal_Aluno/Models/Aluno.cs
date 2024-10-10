using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Aluno.Models
{
    public class Aluno
    {
        public Aluno(string nome, string idade, string curso)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatorio!");
            }

            if (string.IsNullOrEmpty(idade))
            {
                throw new Exception("Idade é obrigatorio!");
            }

            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("Curso é obrigatorio!");
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }

    }
}
