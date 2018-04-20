using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestarauntData.ViewModels;

namespace RestarauntData
{
    public class RestarauntRepository : DbContext
    {

        private readonly DbContext _dbContext;
       

        public RestarauntRepository() : base("name=RestaurauntDb")
        {

        }
        public DbSet<Restauraunt> Restauraunts{ get; set; }


        ResterauntVm GetResteraunt()
        {

            ResterauntVm resteraunt = new ResterauntVm();
            foreach (var rest in Restauraunts)
            {
                rest.Name = resteraunt.Name;

            }


            return resteraunt;


        }

    }
}
