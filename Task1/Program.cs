Console.WriteLine("Введите первое число");
int FirstNumber =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber =int.Parse(Console.ReadLine());
int HightNumber = 0;
int SmallNumber = 0;
 
    if (FirstNumber > SecondNumber) {
    HightNumber = FirstNumber;
    SmallNumber = SecondNumber;
     Console.WriteLine("Большее число " + HightNumber);
    Console.WriteLine("Меньшее число " + SmallNumber);
    }
 
    else if (FirstNumber < SecondNumber) {
           
        HightNumber = SecondNumber;
        SmallNumber = FirstNumber;
        
    Console.WriteLine("Большее число " + HightNumber);
    Console.WriteLine("Меньшее число " + SmallNumber);
    }
    else {
        Console.WriteLine("Числа ровны");
        
    }