using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphisymYarisOrnegi.Models
{
    public class Ihsan : Character
    {  
        public override int GetSpeed()
        {
			Random random2 = new Random();
			return random2.Next(5,20);
        }
    }
    
}
