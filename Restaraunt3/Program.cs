using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarauntData;
namespace Restaraunt3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> RatingsList = new List<double>();
            Restaurants restaraunt = new Restaurants()
            {
                Name = "Bobs Burgers",
                Ratings = RatingsList
            };
         Console.WriteLine(  GetAverageRatings(restaraunt));
            Console.ReadLine();

        }

        public static List<Restaurants> getRestauraunt()
        {
            List<Restaurants> listOfRestaraunts = new List<Restaurants>();


            return listOfRestaraunts;

        }
        public static double GetAverageRatings(Restaurants restaurants)
        {


            List<double> RatingsList = new List<double>();
            RatingsList.Add(2.0);
            RatingsList.Add(3.0);
            RatingsList.Add(5.0);
            Restaurants restaraunt = new Restaurants()
            {
                Name = "Bobs Burgers",
                Ratings = RatingsList
            };
            List<double> ListOfRestaraunts = new List<double>();

            var average = restaraunt.Ratings.Sum() / restaraunt.Ratings.Count;
               

            return average;
        }


    }
}
