using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Models.Social
{
    public class Game : IComparable<Game>
    {
        public string name;
        public int ocen;
        public string url;
        public string id;

        public string color
        {
            get
            {
                return $"rgb({(int)(255 - ocen * 2.55)}, {(int)(ocen * 2.55)}, 0)";
            }
        }

        public int CompareTo(Game o)
        {
            return this.ocen.CompareTo(o.ocen);
        }

        public Game() 
        {
            id = "c" + singlton.Id;
        }
    }
}
