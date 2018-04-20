using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestarauntData;
using System.Data.Entity;

namespace RestaurauntReviews.bl
{
    class Reviews : IRatings
    {


        double IRatings.GetRestaurauntAverageRating(int ResterauntId)
        {
            RestarauntRepository restarauntRepository = new RestarauntRepository();
            try
            {

                var RatingAverage = restarauntRepository.Restauraunts.Where(r => r.RestaurauntId == ResterauntId)
                      .Average(r => r.Rating);
                return RatingAverage;


            }
            catch
            {


            }
            return 0;

        }
    }
}
