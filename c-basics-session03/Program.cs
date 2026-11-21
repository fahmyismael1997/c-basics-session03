using System.Security.Cryptography;
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

            string book1 = "clean code";
            string book2 = "clean code";
            Console.WriteLine(string.ReferenceEquals(book1,book2));

            #endregion
        }
    }
}
