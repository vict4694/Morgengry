using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        //private List<Book> books = new List<Book>();
        //private List<Amulet> amulets = new List<Amulet>(); //fungerer kun med 3 amuletter
        private List<Merchandise> merchandises = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                {
                    amulets.Add(amulet);
                }
            }


        }
        public double GetValueOfMerchandise (Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                double totalValue = 0;
                for (int i = 0; i < 3; i++)
                {
                    Amulet currentAmulet = amulets[i];
                    totalValue = totalValue + Utility.GetValueOfAmulet(currentAmulet);
                }
                return totalValue;
            }
            else if (merchandise is Book)
            {
                double value = 0.0;
                for (int i = 0; i < books.Count; i = i + 1)
                {
                    value = value + books[i].Price;
                }
                return value;
            }
            else
            {
                return 0.0;
            }
        }

    }
}
