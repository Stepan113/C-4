Console.WriteLine("Введите число, которое нужно возвести в степень: ");
int num_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int num_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(power(num_1,num_2));
int power(int x,int y)
{
    if (y==1) return x;
    else if (y==0) return 1;
    else
    {
        return (x*power(x,y-1));
    }
}