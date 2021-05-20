using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arenafighter
{
    public class Round
    {
        public int dice { get; set; }

        public Round()
        {
            Random rand = new Random();
            dice = rand.Next(1, 7);
        }

        

        

        


        

        

    }
}
