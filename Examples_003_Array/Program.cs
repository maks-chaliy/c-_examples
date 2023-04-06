//==================================================================
//int[] array = new int[5];

/*
string[] names = new string[] { "John", "Bob", "Alex" };
names[1] = "Jane";

for (int i = 0; i < names.Length; i++)
{
  Console.WriteLine($"Name: {names[i]}");
}
*/

//==================================================================

/*
int[] arrayNumbers = new int[10];

for (int i = 0; i < arrayNumbers.Length; i++)
{
  int randomNumber = new Random().Next(0, 11);
  arrayNumbers[i] = randomNumber;
  Console.WriteLine(arrayNumbers[i]);
}
*/

//==================================================================

// цикл foreach удобен для перебора двумерных массивов
// так же хорошо перебирает и одномерные массивы

/*
int[,] twoDimensionalArray = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8 ,9}
  };

foreach (int el in twoDimensionalArray)
{
  Console.WriteLine($"Element: {el}");
}
*/

//==================================================================

// динамические массивы

List<int> numbers = new List<int>() {1, 2, 3};

numbers.Add(40);
numbers.Add(50);
numbers.Add(60);

// удаление элемента в массиве
// удаляет не по индексу а по значению
numbers.Remove(100);

// сортировка массива от меньше к большему
numbers.Sort();

// перевернуть массив
numbers.Reverse();

// очистить, удалить все элементы в массиве
numbers.Clear();

// копировать массив
numbers.CopyTo();

// проверяет существует ли элемент по его значению
// вернет true или false
numbers.Exists();

// поиск по значению элемента
// возвращает его индекс
numbers.Find();

Console.WriteLine(numbers);