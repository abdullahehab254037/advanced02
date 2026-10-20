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
            b = temp;
        }
        #endregion
        #region question4
        public static T findmax<T>(T[] items) where T : IComparable<T>, INumber<T>
        {

            T maxvalue = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] > maxvalue)
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
    public class structconstrain<T> where T : struct
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
    #region question 10
    class Animal
    {
    }

    class Dog : Animal
    {
    }
    class baseclass<T> where T:Animal
    {
    }


    #endregion
    #region question11
    class baseclass2<T> where T : class,IRepository<T>,new()
    {
    }
    // multiple constrains must be in this order => primary,secondry,new()

    #endregion
    #region question12,13,14,,15,16,17
    //The default keyword returns the default value of a type T
    class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
                return default(T);

            return items[index];
        }
    }
    //Covariance allows a generic type to use a more derived type than the specified type parameter.
    //The out keyword is used when a type parameter is returned as output.


    //Contravariance allows a generic type to use a less derived type than the specified type parameter.
    //The in keyword is used when a type parameter is accepted as input.

    //Covariance (out) preserves the direction of inheritance, allowing a more derived type.
    //Contravariance (in) reverses the direction, allowing a less derived type.

    //  generic static can work with any type of classes
    #endregion

}