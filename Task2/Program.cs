Console.WriteLine("Введите первое число");
int ImputNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе  число");
int ImputNumber2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ImputNumber3 = int.Parse(Console.ReadLine());

int max = 0;

if (max < ImputNumber1) {
     max = ImputNumber1;
}
if (max < ImputNumber2) {
    max = ImputNumber2;
}
if (max < ImputNumber3) {
    max = ImputNumber3;
}
Console.WriteLine("Самое большое число" + max);