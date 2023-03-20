// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа это "+stringNumber[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// сделать проверку по трай/пас

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();

// не получается пихнуть в код ниже проверку по double.TryParse() или по int.TryParse() =``(((( 

// Console.Write("Введите число: ");
// int RandomNumber = Convert.ToInt32(Console.ReadLine());
// string RandomNumberString = Convert.ToString(RandomNumber);
// if (RandomNumberString.Length > 2){
//   Console.WriteLine("третья цифра это " + RandomNumberString[2]);
// }
// else {
//   Console.WriteLine("третьей цифры нет");
// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Какой сегодня день по счёту в неделе? ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void TodayIsDayoff (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Друг, сколько в неделе дней?))");
  }
  else Console.WriteLine("этот день рабочий");
}

TodayIsDayoff(dayNumber);