using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerançaTest;
namespace HerançaTest
{
    public class Passaro : Animal
    {
        public Passaro(string nome, int idade) : base(nome, idade)
        {
        }

        public override EspecieAnimal Especie => EspecieAnimal.Psittacidae;
        public override string Locomoção => "Voa/Anda";
    }
}
