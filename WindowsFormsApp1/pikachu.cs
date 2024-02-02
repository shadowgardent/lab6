using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class pikachu : Pokemon
    {
        public pikachu() 
        {
            name = "pikachu";
            id = 1;
            level = 1;
            type = pokemonType.Electr;
        
        }
    }


    public class bulbasaur : Pokemon
    {
        public bulbasaur()
        {
            name = "bulbasaur";
            id = 2;
            level = 2;
            type = pokemonType.Grass;

        }
    }

    public class Raichu : Pokemon
    {
        public Raichu()
        {
            name = "Raichu";
            id = 3;
            level = 2;
            type = pokemonType.Electr;

        }
    }

    public class Ekans : Pokemon
    {
        public Ekans()
        {
            name = "Ekans";
            id = 4;
            level = 21;
            type = pokemonType.Poison;

        }
    }

    public class arbok : Pokemon
    {
        public arbok()
        {
            name = "arbok";
            id = 5;
            level = 5;
            type = pokemonType.Poison;

        }
    }
    public class Exeggcute : Pokemon
    {
        public Exeggcute()
        {
            name = "Exeggcute";
            id = 6;
            level = 99;
            type = pokemonType.Grass;

        }
    }

    public class phanpy : Pokemon
    {
        public phanpy()
        {
            name = "phanpy";
            id = 7;
            level = 999;
            type = pokemonType.ground;

        }
    }



}
