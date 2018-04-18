using AC_06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AC_06.Controllers
{
    [RoutePrefix("api/Book")]
    public class BookController : ApiController
    {
        
        static List<Book> BookList = new List<Book>()
        {
            new Book {BookName = "The Great Alone", Author = " Kristin Hannah" , Category = "novel",Status = true},
            new Book {BookName = "Educated", Author = "Tara Westover" , Category = "Novel",Status = true },
            new Book {BookName = "Literature: A Portabl", Author = "Janet E. Gardner" , Category = "literature",Status = true },
            new Book {BookName = "Algorithms to Live", Author = "Brian Christian" , Category = "computer science",Status = true },
            new Book {BookName = "Introduction to Data Mining", Author = " Pang-Ning Tan" , Category = "computer science",Status = true },
            new Book {BookName = "Democracy in Chains", Author = "Nancy MacLean" , Category = "history",Status = true },
            new Book {BookName = "The Secret History", Author = " Donna Tartt" , Category = "history",Status = true },
            new Book {BookName = "Political Science", Author = "Robert A Heinem" , Category = "political science",Status = true },
            new Book {BookName = "Barron's Math Workbook", Author = " Lawrence S. Leff " , Category = "math",Status = true },
            new Book {BookName = "Ready Player One", Author = " Ernest Cline" , Category = "science",Status = true },
        };
        // GET: api/Book
        public List<Book> Get()
        {
            List<Book> temp = new List<Book>();
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Status == true)
                    temp.Add(BookList[i]);
            }
            return temp;
        }

        // GET: api/Book/5
        public Book Get(int id)
        {
            return BookList[id];
        }

        [Route("{id}/{element}")]
        // GET: api/Book/1/2
        public HttpResponseMessage Get(int id, int element)
        {
            string returnName;
            string returnValue;

            switch(element)
            {
                case 1:
                    returnValue = BookList[id].BookName;
                    returnName = "Book-Name";
                    break;
                case 2:
                    returnValue = BookList[id].Author;
                    returnName = "Book-Author";
                    break;
                case 3:
                    returnValue = BookList[id].Category;
                    returnName = "Book-Category";
                    break;
                case 4:
                    returnValue = BookList[id].Status.ToString();
                    returnName = "Book-Status";
                    break;
                default:
                    returnValue = "900";
                    returnName = "Error-Code";
                    break;
            }
            HttpResponseMessage returnResponse = new HttpResponseMessage();
            returnResponse.Headers.Add(returnName, returnValue);
            return returnResponse;
        }

        // GET: api/Book?category=computer science
        public List<Book> Get(string category)
        {
            List<Book> temp = new List<Book>();
            for(int i=0; i< BookList.Count; i++)
            {
                bool areEqual = String.Equals(BookList[i].Category, category, StringComparison.Ordinal);
                if (areEqual)
                    temp.Add(BookList[i]);
            }
            return temp;
        }

        // POST: api/Book
        public void Post([FromBody]Book value)
        {
            BookList.Add(value);
        }
        // POST: api/Book?name=xy23&author=djfd&cat=gjjj
        public void Post(string name, string author, string cat)
        {
            Book temp = new Book();
            temp.BookName = name;
            temp.Author = author;
            temp.Category = cat;
            temp.Status = true;
            BookList.Add(temp);
        }
        //api/Book?name=xy23&author=djfd
        public void Post(string name, string author)
        {
            Book temp = new Book();
            temp.BookName = name;
            temp.Author = author;
            temp.Category = "unknown";
            temp.Status = true;
            BookList.Add(temp);
        }
        //reserveBook or freebook
        // PUT:api/Book?name=Algorithms%20to%20Live&req=r
        public void Put(string name,char req)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].BookName == name)
                {
                    if (req == 'r' || req == 'R')
                        BookList[i].Status = false;
                    if (req == 'f' || req == 'F')
                        BookList[i].Status = true;
                }
             }
        }
        // PUT: api/Book/5
        public void Put(int id, [FromBody]Book value)
        {
            BookList[id] = value;
        }

        // PUT: api/Book?name1=&name2=
        public void Put(string name1, string name2)
        {
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].BookName == name1 || BookList[i].BookName == name2)
                {
                    BookList[i].Status = true;
                }
            }
        }

        // DELETE: api/Book/5
        public HttpResponseMessage Delete(int id)
        {
            int count = BookList.Count;
            if (id > count)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            BookList.RemoveAt(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // DELETE: api/Book?name=
        public HttpResponseMessage Delete(string name)
        {
            int count = BookList.Count;
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].BookName == name)
                {
                    BookList.RemoveAt(i);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }
    }
}
