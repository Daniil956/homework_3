Console.Clear();
Console.Write("Enter numbers: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstAction = number % 10 * 10;
int secondAction = number % 100 / 10;
int firstMethods = firstAction + secondAction;
int secondMetohods = number / 1000;
if (firstMethods == secondMetohods) Console.Write("Yes");
else Console.Write("No");


// как написать программу для числел больше, чем тятизначное???????
