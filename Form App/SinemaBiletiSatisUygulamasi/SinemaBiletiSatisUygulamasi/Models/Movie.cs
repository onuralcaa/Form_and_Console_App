using SinemaBiletiSatisUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletiSatisUygulamasi.Models
{
    public class Movie:BaseClass
    {
        public Movie()
        {
            SetDeafultSessions();
        }

        public string picturePath { get; set; }
        public string minute { get; set; }
        public decimal price { get; set; }
        public Category category { get; set; }
        public List<Session> sessions { get; set; }

        private void SetDeafultSessions()
        {
            sessions= new List<Session>();
            DateTime currentDate = DateTime.Now;
            TimeSpan ts = new TimeSpan(10,30,0);

            for(int i=0; i<3; i++)
            {
                currentDate = currentDate.Date + ts;

                for(int j=0; j<3; j++)
                {
                    Session session = new Session();
                    session.date = currentDate.ToShortDateString();
                    session.time= currentDate.ToShortTimeString();
                    sessions.Add(session);
                    currentDate = currentDate.AddHours(3);
                }

                currentDate = currentDate.AddDays(1);
            }





        }


    }
}
