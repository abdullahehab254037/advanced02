using System.Numerics;

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
        #region question4
        public static T findmax<T>(T[] items) where T : IComparable<T>, INumber<T>
        {

            T maxvalue = items[0];
            for( int i=1;i<items.Length;i++)
            {
                if (items[i]>maxvalue)
                {
                    maxvalue = items[i];
                }
            }
            return maxvalue;


            return default;
        }

        #endregion
    }
    #region question5
    public interface IRepository<T>
    {
        // interface that work with different data types
        void Add(T item);
        T Get();
    }
    #endregion
    #region question6
    public class structconstrain<T> where T:struct
    {
        // make class work with types that have base "struct" only
    }
    #endregion
    #region question7
    public class classconstrain<T> where T : class
    {
        // make class work with types that have base "class" only
    }
    #endregion
    #region question8
    public class newconstrain<T> where T : new()
    {
        // make class work with types that have base "no parameter constructor" only
    }
    #endregion
    #region question 9
    public class gen<T> : IRepository<T>
    {
        // T must impelemnt the interface
        public void Add(T item)
        {
            
        }

        public T Get()
        {
            return default;
        }
    }
    #endregion
}

