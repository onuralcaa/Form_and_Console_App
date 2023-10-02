using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphisymYarisOrnegi.Models
{
    
    public class Hasan : Character
    {
    
		public override int GetSpeed()
        {
			Random random4 = new Random();
			return random4.Next(5,20);   
        }

    }
}
