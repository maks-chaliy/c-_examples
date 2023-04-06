//=================================================

int res1 = Sum(2, 5);
int a = 4, b = 6;
int res2 = Sum(a, b);

Print(res1.ToString());
Print(res2.ToString());

void Print(string text)
{
  Console.WriteLine(text);
}


int Sum(int num1, int num2)
{
  return num1 + num2;
}

//=================================================

// подсчет элементов массива    
int[] numberArr = { 2, 3, 5, 9, 10 };

int SumArr(int[] arr)
{
  int result = 0;
  foreach (int el in arr)
  {
    result += el;
  }

  return result;
}

Console.WriteLine(SumArr(numberArr));
