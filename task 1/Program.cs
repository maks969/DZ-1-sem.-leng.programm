// программа на вход два числа, выводит большее и меньшее.
// 5-7.2-10

      
Console.WriteLine($"введите первое число-");
            string input1 = Console.ReadLine()!;
        int a = int.Parse(input1);
Console.WriteLine($"введите второе число-");
            string input2 = Console.ReadLine()!;
            int b = int.Parse(input2);
          
        int max = a;
        int min = b;
        if (min == max) Console.WriteLine("числа равны!");
        if (b > max)
          {
            max = b;
            min = a;
          }

        Console.WriteLine($"max = {max} ");
        Console.WriteLine($"min = {min} ");