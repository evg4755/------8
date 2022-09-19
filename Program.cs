Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int startNum = 1;
while(startNum <= num)
    {
        if(startNum % 2 ==0)
        Console.Write(startNum + ", ");
        startNum ++;
    }