namespace advanced1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Generic class is fixed class with any data type we make it like this: public class ClassName<T>
            //it's avoid doublicates in code and it's better than object because object need Boxing/UnBoxing and this not good perform and can make run time error
            #endregion

            #region Q3
            //it's a generic that can take different type at once like: pair<TKey,TValue> => pair<int,string>



            //Pair<int,string> pair = new Pair<int,string>(10,"Ali");
            #endregion

            #region Q4
            //Generic method it's a method which is fixed with data type made for avoiding doublicates

            Swap swap = new Swap();
            int x = 10;
            int y=50;
            swap.Swaping<int>(ref x,ref y);
            Console.WriteLine($"X: {x} , Y: {y}");
            #endregion
        }
    }
}
