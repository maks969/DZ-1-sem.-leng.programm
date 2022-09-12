Console.WriteLine($"введите первое число-");
            string input1 = Console.ReadLine();
        
Console.WriteLine($"введите второе число-");
            string input2 = Console.ReadLine();
          
  int a = int.Parse(input1);
  int b = int.Parse(input2);
Console.WriteLine($"min = {Math.Min(a, b)}");
Console.WriteLine($"max = {Math.Max(a, b)}");
