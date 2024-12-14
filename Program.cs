class Task_wave1
{
     public static void Main()
    {   //task1
        int num1=4, num2=5;
        int sum=num1 + num2;
        Console.WriteLine($"the sum is {sum}");
        Console.WriteLine("====================================");
        //task2
     
            int result1 = -1 + 4 * 6;
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"Result of -1 + 4 * 6: {result1}");
            Console.WriteLine($"Result of (35 + 5) % 7: {result2}");
            Console.WriteLine($"Result of 14 + -4 * 6 / 11: {result3}");
            Console.WriteLine($"Result of 2 + 15 / 6 * 1 - 7 % 2: {result4}");
        Console.WriteLine("====================================");
        //task3

        int a = 5, b = 10, c = 15;

            // Comparisons
            Console.WriteLine($"Is a < b and b < c? {a < b && b < c}");
            Console.WriteLine($"Is c greater than a and not equal to b? {c > a && c != b}");
            Console.WriteLine($"Is a + b greater than c or b - a equal to c? {(a + b > c || b - a == c)}");
            Console.WriteLine($"Is a multiplied by b less than c * 3? {a * b < c * 3}");
            Console.WriteLine($"Is (c - b) + a equal to b? {(c - b) + a == b}");
        
     }
    
}

 
