// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine($"Введите числа: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[x];

void InputNumbers(int x){
for (int i = 0; i < x; i++)
  {
    Console.WriteLine($"Введите {i+1} числа: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(x);

Console.WriteLine($"Введено чисел больше 0: {Comparison(arrayNumbers)} ");
