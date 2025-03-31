using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula156.Entities
{
    class Aluno
    {
        public int Alunos { get; set; }
        public string Curso { get; set; }

        public override int GetHashCode()
        {
            return Alunos.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Aluno))
            {
                throw new ArgumentException("Comparing error: argument is not a Aluno");
            }
           Aluno other = obj as Aluno;
            return Alunos.Equals(other.Alunos);
        }
    }
}
