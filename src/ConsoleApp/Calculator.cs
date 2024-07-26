namespace ConsoleApp
{
    public class Calculator
    {
        public int? CalculateArea(int x, int y) { 

            if(x<0 || y<0) return null;

            if (x * y > Int32.MaxValue || x*y < 0) return null;

            return x * y;
        }
    }
}
