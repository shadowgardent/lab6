using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected pokemonType type;
        protected pokemonAbilities abilities;
        protected int hp;
        protected int atk;
        protected int def;
        protected int Satk;
        protected int Sdef;
        protected int Speed;

        public string Name()
        {
            return name;
        }
        public Image picture()
        {
            return pic;
        }

    }

     public enum pokemonType
        { 
        Grass, Poison,Electr,ground
        }
    public enum pokemonAbilities
    {
        overgrow, chlorophyII
    }
}
