using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerançaTest
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public abstract EspecieAnimal Especie { get; }
        public virtual string Locomoção { get { return "Anda"; } }
        public Animal(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        
        
    }
}
