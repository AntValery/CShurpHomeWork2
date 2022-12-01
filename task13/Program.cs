Console.Write("Введите число = ");
int n = Convert.ToInt32(Console.ReadLine());
int tmp = n;

int count = 0;
while(tmp != 0){
    tmp /= 10;
    count++;
}

if(count < 3) Console.WriteLine("В числе меньше 3 цифр");
else Console.WriteLine((int)Math.Abs(((n / Math.Pow(10, (count - 3))) % 10)));