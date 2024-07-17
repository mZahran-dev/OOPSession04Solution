using OOPSession04.Interface_Example02;
using OOPSession04.Interface_Example03;

namespace OOPSession04
{
    internal class Program
    {
        public static void print10NumbersFromSeries(ISeries seriesByTwo)
        {
            if (seriesByTwo == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{seriesByTwo.Current}\t");
                seriesByTwo.GetNext();
            }
            seriesByTwo.Reset();
            Console.WriteLine();
        }
        //public static void print10NumbersFromSeriesByThree(SeriesByThree seriesByThree)
        //{
        //    if (seriesByThree == null)
        //        return;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{seriesByThree.Current}\t");
        //        seriesByThree.GetNext();
        //    }
        //    seriesByThree.Reset();
        //    Console.WriteLine();
        //}



        static void Main(string[] args)
        {
            #region Example02
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            print10NumbersFromSeries(seriesByTwo);

            SeriesByThree seriesByThree = new SeriesByThree();
            print10NumbersFromSeries(seriesByThree);
            #endregion

            #region Example03
            Airplane airplane = new Airplane();
            IMovable movable = new Airplane();
            IFlyable flyable = new Airplane();
            flyable.Forward();
            airplane.Forward();

            #endregion

            #region Shallow Copy vs Deep Copy [Value type]








            #endregion

            #region Shallow Copy vs Deep Copy [Reference type]








            #endregion



        }
    }
}
