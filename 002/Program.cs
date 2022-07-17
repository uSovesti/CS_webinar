// Task_2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго.
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
    //типы операций  ==,  !=,  <,  >,  >=, <=, 
if (a*a==b)
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
     if (b*b==a)
        {
            System.Console.WriteLine("a является квадратом b");
        }
        else
        {
                System.Console.WriteLine("Числа не являются квадратами");
        }
}












/*
if (2*2==4) // ПОЛНОЕ УСЛОВИЕ, где может выполняться либо if, либо  else, при if - выполняется true, при else - false.
{
    //true
}
else
{
    //false
}


if (2*2==4) // НЕ ПОЛНОЕ УСЛОВИЕ, где если if будет true, то выполняется действие, а если false, то наоборот.
{
    //true
}
*/