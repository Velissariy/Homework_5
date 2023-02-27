// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("1 - Программа для подсчета количества четных чисел в массиве случайных трёхзначных чисел.");
Console.WriteLine("2 - Программа для подсчета суммы чисел в массиве, стоящих на нёчетных позициях.");
Console.WriteLine("3 - Программа для подсчета разницы между максимальным и минимальным элементов массива вещественных чисел.");
int numberOfTask = Prompt("Введите номер задачи");

int Length = Prompt ("Введите длину массива: ");
     
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_34();
                break;

                case 2:
                Console.Clear();
                Task_36();
                break;

                case 3:
                Console.Clear();
                Task_38();
                break;

                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }
static int Prompt(string message)// Метод запроса числа.
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

void PrintArray(int[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
       {
          System.Console.Write($"{array[i]}, ");
        }
        System.Console.Write($"{array[Length - 1]}");
        System.Console.Write("]");
}
void Task_34() // Метод подсчета количества четных чисел в массиве
  {

    int count = 0;
        int[] array = new int[Length];
        Random random = new Random();
        for (int i = 0; i < Length; i++)
        array[i] = random.Next(100, 999);
          

for (int ind = 0; ind < array.Length; ind++)
  {
     if (array[ind]%2 == 0)
     count ++;
  }
     
PrintArray(array);  
Console.WriteLine(" количество четных чисел в массиве" + " -> " + count); 
}

void Task_36()// Метод нахождения суммы чисел в массиве.
{
    int[] arr = new int[Length];
    Random random = new Random();
            
     for (int i = 0; i < Length; i++)
     arr[i] = random.Next(-99, 99);
     
int sum = 0;
{for (int index = 1; index < Length; index++)
    {
      if (index%2 > 0)
      sum = sum + arr[index];
    }
}

PrintArray(arr);  
Console.WriteLine();
Console.WriteLine("сумма элементов, стоящих на нечётных позициях: " + sum); 
}


void Task_38() // Метод заполнения массива из 8 элементов и показа его на экране.
{
double[] arr = new double[Length];
  Random random = new Random();
  for (int i = 0; i < arr.Length; i++)
   {  
    arr[i] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1    
   }
double min = arr[0];
for (int i=0;i<arr.Length;i++)
{
  if (arr[i] < min)
  {
    min = arr[i];
  }
}

double max= arr[0];
for (int i=0;i<arr.Length;i++)
{
  if (arr[i] > max)
  {
    max = arr[i];
  }
}
double result = max-min;
System.Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
            {
            System.Console.Write($"{arr[i]}, ");
            }
        System.Console.Write($"{arr[arr.Length - 1]}");
        System.Console.Write("]");
    Console.WriteLine();    
Console.WriteLine("разница между максимальным и минимальным элементами массива: "+ result);
}
