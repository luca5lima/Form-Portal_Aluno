using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Aluno.Models
{
    public class Aluno
    {

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }

        public Aluno(string nome, int idade, string curso)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Expression("Nome é obrigatorio!");
            }

            if (string.IsNullOrEmpty(idade))
            {
                throw new Expression("Idade é obrigatorio!");
            }

            if (string.IsNullOrEmpty(curso))
            {
                throw new Expression("Curso é obrigatorio!");
            }

            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

    }
}
