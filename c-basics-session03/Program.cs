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

            //int pages = 464;
            //bool isAvailable = true;

            //if (pages>300&&isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            #endregion

            #region Question 10
            /*Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is 
              "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.*/

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":

            //        Console.WriteLine("Great choice!");
            //        break;
            //     case "Refactoring":
            //        Console.WriteLine("Nice pick");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question 11
            /*Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a 
              variable sizeLabel (same rule as question 8: long if pages > 300).*/

            //int pages = 464;
            //string sizeLable;
            //sizeLable= pages > 300 ? sizeLable = "Long Book" : sizeLable = "short Book";
            //Console.WriteLine(sizeLable);
            #endregion

            #region Question 12
            /*Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop 
             to print each book with its position number, like 1. Clean Code.*/

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i+1}. {books[i]}");
            }
            #endregion

            #region Question 12
            /*Using the same books array, use a while loop to print every book title.*/
            //int counter = 0;
            //while (counter<books.Length)
            //{
            //    Console.WriteLine(books[counter]);
            //    counter++;
            //}
            #endregion

            #region Question 13
            /*Write a do-while loop that prints "Checking book..." exactly 3 times*/

            //int j = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    j++;
            //}
            //while (j<3);
            #endregion

            #region Question 14
            /*Using the same books array, use a foreach loop to print every book title. */
            //foreach (string item in books)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question 15
            /*Using the same books array, loop through it and print each title, but stop completely (break) once 
              you reach "Refactoring".*/

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                    break;

                Console.WriteLine(books[i]);
                    
                
            }
            #endregion
        }
    }
}
