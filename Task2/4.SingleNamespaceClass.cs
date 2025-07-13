using System;
using System.Web;

//4 & 11 Prepare the example with non-static class and add static members

namespace Library
{
    class BookCollection
    {
        public string CustomerName {get; set;}
        public int CustomerId { get; set;}

    
        public void BookDetails(string customername, string bookname, int customerid)
        {
            Console.WriteLine($"Customer Name: {customername} and Customer Number: {customerid}, Collected Book: {bookname}");
        }

    }
    class ArticleCollection
    {
        public static string ArticleName;

        public static string AuthorName { get; set; }   
        public static string AuthorUrl { get; set; }

        static ArticleCollection()
        {
            ArticleName = "MS DHONI";
            AuthorName = "Micheal";
            AuthorUrl = "http.www.url.com";
        }


        public static string GetArticleDetails()
        {
           string str = $"Article Details:\n Article Name: {ArticleName}\n Author Name: {AuthorName}\n Author Url: {AuthorUrl}";
            return str;
        }

    }

    class Program
    {

        static void Main()
        {
            Console.WriteLine("********************Single Namespace and Classes************************");
            Console.WriteLine("********************Library************************");
            BookCollection bookCollection = new BookCollection();
            bookCollection.BookDetails("Sophia", "THE ART OF BEING ALONE", 1001);

            
            ArticleCollection.GetArticleDetails();
            
            
        }
    }
}
