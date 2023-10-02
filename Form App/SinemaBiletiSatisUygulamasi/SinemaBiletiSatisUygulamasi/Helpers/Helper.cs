using SinemaBiletiSatisUygulamasi.Enums;
using SinemaBiletiSatisUygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletiSatisUygulamasi.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:\\Users\\onura\\OneDrive\\Masaüstü\\C# dersleri\\Form App\\SinemaBiletiSatisUygulamasi\\SinemaBiletiSatisUygulamasi\\Pictures\\";
            return new List<Movie>()
            {
                 new Movie
                {
                    movieName = "Bir komedi Filmi 3",
                    category = Category.komedi,
                    minute = "1 saat 22 dakika",
                    price = 55,
                    picturePath = basePath + "hatal.jpg"
                },
                new Movie
                {
                    movieName = "Jason Statham ve İhsan ERDEM",
                    category = Category.macera,
                    minute = "1 saat 42 dakika",
                    price = 60,
                    picturePath = basePath + "Reis_Film.jpg"
                },
               
                new Movie
                {
                    movieName = "Korku kentinde bir gece",
                    category = Category.gerlim,
                    minute = "2 saat 12 dakika",
                    price = 65,
                    picturePath = basePath + "idirin.jpg"
                },
                new Movie
                {
                    movieName = "Maveric Pro Uçak Muçak",
                    category = Category.macera,
                    minute = "2 saat 32 dakika",
                    price = 70,
                    picturePath = basePath + "ierdem.jpg"
                },
                new Movie
                {
                    movieName = "Robotların Savaşı 3",
                    category = Category.bilim_kurgu,
                    minute = "1 saat 43 dakika",
                    price = 73,
                    picturePath = basePath + "oalcaa.jpg"
                },
                new Movie
                {
                    movieName = "Köpek balığı denizi 2",
                    category = Category.fantastik,
                    minute = "2 saat 6 dakika",
                    price = 67,
                    picturePath = basePath + "sanverdi.jpg"
                }
            };
        }       
    }
}