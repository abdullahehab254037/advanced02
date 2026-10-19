namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }
    public class generic<T>
    {
        #region question3
        public static void swap(ref T a, ref T b)
        {   // generic method is method that can handle any type of attributes
            T temp = a;
            a = b; 
            b=temp;
        }
        #endregion
    }
}

