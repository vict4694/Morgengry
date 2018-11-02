//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morgengry
//{

//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet>();
//        //public int counter = 0;
//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add(amulet);
//            //amulets[counter] = amulet;
//            //counter = counter + 1;

//            //int i = 0;
//            //amulets[i] = amulet;
//            //i = i + 1;


//            ////int amuletsLength = amulets.Length;
//            //for (i = 0; i < 3; i++)
//            //{
//            //    amulets[i] = amulet;
//            //}
//            ////return amulets;
//        }

//        public double GetTotalValue()
//        {
//            double totalValue = 0;
//            for (int i = 0; i < 3; i++)
//            {
//                Amulet currentAmulet = amulets[i];
//                totalValue = totalValue + Utility.GetValueOfAmulet(currentAmulet);
//                //Level q = amulets[i].Quality;
//                //if (q == Level.low)
//                //{
//                //    totalValue = totalValue + 12.5;
//                //}
//                //else if (q == Level.medium)
//                //{
//                //    totalValue = totalValue + 20.0;
//                //}
//                //else
//                //{
//                //    totalValue = totalValue + 27.5;
//                //}
//            }
//            return totalValue;
//            //return 60.0;
//        }
//        //public Amulet GetBook(itemId)
//        //{
//        //    for (int i = 0; i < amulets.Length; i++)
//        //    {
//        //        if (itemId ==  )
//        //    }
//        //}

//    }
//}
