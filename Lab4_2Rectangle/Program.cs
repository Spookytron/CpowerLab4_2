using System;

//when running the tests I tried both the same numbers and different numbers in both rectangle variables and got the result "Different"
// both times. When I set r1=r2, it returned the option same. I am assuming that this is because without setting r1 to r2 both rectangles
// were hard coded and therefore took up different slots when created, and even though they contained the same basic parts and numbers,
// they were inherently two different things. 



namespace Lab4_2Rectangle
{
    class Rectangle
    {
        public int Length;
        public int Width;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            r1.Length = 10;
            r2.Length = 10;
            r1.Width = 10;
            r2.Width = 10;
            r1 = r2;
            if (r1 == r2)
            {
                Console.WriteLine("Same");
            }
            else Console.WriteLine("Different");
        }
    }
}
