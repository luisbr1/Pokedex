using System.Collections.Generic;

namespace Pokedex.Classes
{
    public class Pokemon{

        public int Numero { get; set; }
        public string Nome { get; set; }
        public List<string> Tipo { get; set; }
        public double Altura { get; set; }    
        public double Peso { get; set; }
        public string Imagem { get; set;}

        public Pokemon()
        {
            Tipo= new List<string>();
        }
    }


}