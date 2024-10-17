using static ConsoleNet8.ArrayUtils;

//decimal d = .1m;
//decimal sum = 0m;

////int i = 0;
////while (i < 10)
////{
////    sum += d;
////    ++i;
////}

////int s1 = 0;
////int s2 = 0;

////var k = s1++;

////var h = ++s2;

////for (int i = 0; i < 10; i++)
////{
////    sum += d;
////}

////int i = 0;
////do
////{
////    sum += d;
////    ++i;
////}
////while (i < 10);
////DateTime dt = DateTime.Now;
////string s = "Ciao Mondo";
////int[] ints = Enumerable.Range(0, 10).ToArray(); //[0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

////foreach (int i in ints)
////{
////    sum += d;
////}


////Console.WriteLine($"Sum is equal to 1.0? {(sum == 1.0m ? "YES" : "NO")}");

//int[] ints = [1, 2, 3];

//int indexOf2 = FindFirstIndexOfElement(ints, 15);

//Random random = new Random();

//for (int i = 0; i < 10; i++)
//{
//    int k = random.Next(101);
//}

Console.WriteLine(Factorial(5));
Console.WriteLine(FactorialIterative(5));

int[] a1 = [1, 3, 8, 9];
int[] a2 = [1, 2, 4, 8, 10];

// [1, 1, 2, 3, 4, 8, 8, 9, 10]


PrintArray(a1);
Console.WriteLine("----");
PrintArray(a2);
Console.WriteLine("----");
PrintArray(MergeSortedArrays(a1, a2));
//Console.WriteLine("----");
//SelectionSort(a1);
//PrintArray(a1);




