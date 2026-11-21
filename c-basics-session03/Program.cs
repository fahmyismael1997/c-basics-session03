using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            /*Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print 
            both title and upperTitle to show that title did not change.*/

            //string title = "clean code";
            //string upperTitle=title.ToUpper();

            //Console.WriteLine($"title ={title}\nupperTitle = {upperTitle}");
            #endregion

            #region Question 2
            /*Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() 
             to check if they point to the same object in memory.*/

            //string book1 = "clean code";
            //string book2 = "clean code";
            //Console.WriteLine(string.ReferenceEquals(book1,book2));

            #endregion

            #region Question 3
            /*Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same 
             object. Print the final result.*/

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append("-Update");
            //Console.WriteLine(sb);
            #endregion

            #region Question 4
            /*Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". 
             Print the result.*/

            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion

            #region Question 5
            /*Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
             Pages: 464" using the + operator.*/

            //string Title = "Clean Code",FullText;
            //int pages = 464;
            //FullText = "Book: " + Title + ',' + "pages: " + pages;
            //Console.WriteLine(FullText);
            #endregion

            #region Question 6
            /*Build the same sentence as above, but using string interpolation ($"..."). */

            //string Title = "Clean Code", FullText;
            //int pages = 464;
            //FullText = $"Book: {Title},pages: {pages}";
            //Console.WriteLine(FullText);
            //#endregion
            #endregion

            #region Question 7
            /*Build the same sentence again, but using string.Format().*/

            //string Title = "Clean Code", FullText;
            //int pages = 464;
            //FullText = string.Format("Book: {0},pages: {1}", Title, pages);
            //Console.WriteLine(FullText);

            #endregion

            #region Question 8
            /*Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
              300, otherwise prints "Short Book".*/

            //int Pages = 464;
            //if (Pages>300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion

            #region Question 9
            /*Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
            greater than 300 and isAvailable is true. Use the && operator.*/

            int pages = 464;
            bool isAvailable = true;

            if (pages>300&&isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
           
            #endregion
        }
    }
}
