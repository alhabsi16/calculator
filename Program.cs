internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("calculator");



        Console.WriteLine("Enter The First Number");
        int a = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Enter The Second Number");
        int b = Convert.ToInt32(Console.ReadLine());


        
        Console.WriteLine( a + b );
        Console.WriteLine( a - b );
        Console.WriteLine( b - a );
        Console.WriteLine( a / b );
        Console.WriteLine( b / a );
        Console.WriteLine( a * b );
        Console.WriteLine( a % b );
        Console.WriteLine( b % a );


        // string Ans = (fNum +" "+ sNum);

        //Console.WriteLine("Answer = " + Ans );
        Console.ReadLine();
    }
}