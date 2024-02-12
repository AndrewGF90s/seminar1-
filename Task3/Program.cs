 Console.WriteLine("ВВедите число ");
int number = int.Parse(Console.ReadLine());
int check = number % 2;
 
if ( check == 1 ) {
    Console.WriteLine("Число " + number + " Нечетное" );
}
else {
    Console.WriteLine("Число " + number + " Четное");
}