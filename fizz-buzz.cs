
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void fizzbuzz()
{
    Console.WriteLine();
    Console.WriteLine("ingrese el numero hasta donde quieras");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    for (int i = 1; i <= n1; i++)
    {
        if (i % 3 == 0)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                Console.WriteLine("Fizz");
            }
        }
        else
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
fizzbuzz();
