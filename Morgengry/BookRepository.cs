//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Morgengry
//{
//    public class BookRepository
//    {
//        private List<Book> books = new List<Book>();

//        public void AddBook(Book book)
//        {
//            books.Add(book);

//            //books[i] = book;
//            //private int i = 0;
//            //i = i + 1;
//            //return books;

//        }
//        public Book GetBook(string itemId)
//        {
//            for (int i = 0; i < books.Count; i++)
//            {
//                if (books[i].ItemId == itemId)
//                {
//                    return books[i];
//                }
//            }
//            return null;
//        }
//        //{
//        //   /* bog = itemId.Book;*/ // skriv noget andet, kig på det med q du lavede med krille
//        //    books.Add(itemId);
//        //}

//        public double GetTotalValue()
//        {
//            double value = 0.0;
//            for (int i = 0; i < books.Count; i = i + 1)
//            {
//                value = value + books[i].Price;
//            }
//            return value;
//        }
//    }
//}
