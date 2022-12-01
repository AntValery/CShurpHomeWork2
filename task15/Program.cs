Console.Write("Введите число = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 7) Console.WriteLine("Число не является днём недели");
else if (n > 5 && n <= 7) Console.WriteLine("Да");
else Console.WriteLine("Нет");