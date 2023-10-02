using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphisymYarisOrnegi.Models
{
    public class Say : Character
    {
        public override int GetSpeed()
        {
			Random random3 = new Random();
			return random3.Next(5,20);
        }
    }
}
