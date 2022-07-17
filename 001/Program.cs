
// Task_1. С клавиатуры вводится целое число. Вывести квадрат числа.
int a;
int b;
string? s=Console.ReadLine();  // ввод данных
a=Convert.ToInt32(s);

b = a*a; // обработка данных 

// Ниже указаны два варианта вывода результатов, лучше использовать второй.
System.Console.WriteLine("{0}^2={1}",a,b); //строка форматирования, где 0 и 1 - считывают значения присвоенные для a,b и т.д
System.Console.WriteLine($"{a}^2={b}"); //строка интерполяция при $



/*
string? s;
s=Console.ReadLine();
System.Console.WriteLine(s);
*/