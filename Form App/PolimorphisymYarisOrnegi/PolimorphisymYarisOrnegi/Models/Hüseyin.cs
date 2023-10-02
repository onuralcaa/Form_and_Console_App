using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphisymYarisOrnegi.Models
{
    public class Hüseyin : Character
    {    
        public override int GetSpeed()
        {
            Random random1 = new Random();
            return random1.Next(5,20);
        }
    }
}
