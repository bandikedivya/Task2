using System;


//4 Prepare the example with non-static class and add static members

namespace MyLibrary
{
    class BookCollection
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string BookName { get; set; }

        public BookCollection()
        {
            CustomerName = "Kim";
            CustomerId = 1101;
            BookName = "THE ART OF BEING ALONE";
        }
        public void BookDetails()
        {
            Console.WriteLine($"Customer Name: {CustomerName} and Customer Number: {CustomerId}, Collected Book: {BookName}");
        }
        //public void BookDetails(string customername, string bookname, int customerid)
        //{
        //    Console.WriteLine($"Customer Name: {customername} and Customer Number: {customerid}, Collected Book: {bookname}");
        //}

    }
    static class ArticleCollection
    {
        public static string ArticleName;

        public static string AuthorName { get; set; }
        public static string AuthorUrl { get; set; }

        static ArticleCollection()
        {
            ArticleName = "MS DHONI Blog";
            AuthorName = "Micheal";
            AuthorUrl = "http.www.url.com";
        }


        public static string GetArticleDetails()
        {
            string str = $"Article Details:\nArticle Name: {ArticleName}\nAuthor Name: {AuthorName}\nAuthor Url: {AuthorUrl}";
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
            //bookCollection.BookDetails("Sophia", "THE ART OF BEING ALONE", 1001);
            bookCollection.BookDetails();


            Console.WriteLine(ArticleCollection.GetArticleDetails());


        }
    }
}
