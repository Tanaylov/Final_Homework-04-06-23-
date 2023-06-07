/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */
Console.Clear();

string[] task = {"Написать", "программу,", "которая", "из", "имеющегося", "массива",
                 "строк", "формирует", "новый", "массив", "из", "строк,", "длина", 
                 "которых", "меньше,", "либо", "равна", "3", "символам."};
string[] task2 = {"“1234”", "“1567”", "-2", "“computer science”"};

WrongSolution(task);
CorrectSolution(task2);
CorrectSolution(task);

void WrongSolution(string[] array)
{
  byte size = (byte) new Random().Next(0, 4);
  string[] result = new string[size];
  for(byte i = 0; i < size; i++)
    {
      byte index = (byte) new Random().Next(0, array.Length);
      result[i] = array[index];
    } 
  Console.WriteLine("[" + String.Join(" ", array) + "]" + " -> " + "[" + String.Join(" ", result) + "]");
}

void CorrectSolution(string[] array)
{ 
  byte count = 0;
  foreach(string el in array)
      if(el.Length > 3) count++;
  byte size = Convert.ToByte(array.Length - count);
  string[] solution = new string[size];
  byte index = 0;
  for(byte i = 0; i < array.Length; i++)
    if(array[i].Length < 4) 
    {
      solution[index] = array[i];
      index++;
    }
  Console.WriteLine("[" + String.Join(" ", array) + "]" + " -> " + "[" + String.Join(" ", solution) + "]");
}