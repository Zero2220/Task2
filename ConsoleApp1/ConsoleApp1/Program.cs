using Microsoft.Win32.SafeHandles;
using System.Collections;

List<int> numbers = new List<int>();

numbers.Add(0);
numbers.Add(123);
numbers.Add(23);

foreach (var item in numbers)
{
    Console.WriteLine(item);

}
Console.WriteLine("==============================================================================================");
SortedList<int, string> numbersList = new SortedList<int, string>();

numbersList.Add(1,"Anar");
numbersList.Add(3, "Ahmet");
numbersList.Add(2, "Mehmet");

foreach (var item in numbersList)
{

    Console.WriteLine(item);
}
Console.WriteLine("==============================================================================================");
Queue<string> Sira= new Queue<string>();

Sira.Enqueue("1");
Sira.Enqueue("2");
Sira.Enqueue("3");
var text = Sira.Peek();
var text2 = Sira.Dequeue();

foreach (var item in Sira)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine(text);
Console.WriteLine(text2);
Console.WriteLine("==============================================================================================");

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Pop();
bool yoxlama = stack.Contains(1);
Console.WriteLine(yoxlama);
int num = stack.Peek();

foreach (var item in stack)
{

    Console.WriteLine(item);
}
Console.WriteLine(num);


stack.Clear();
foreach (var item in stack)
{

    Console.WriteLine(item);
}
Console.WriteLine("==============================================================================================");

IDictionary keyValues = new Dictionary<string, object>();


keyValues.Add("secret_key", "secret");
keyValues.Add("secret_key2", "gizli");


    if (keyValues.Contains("secret_key"))
    {

        Console.WriteLine(keyValues["secret_key"]);
    }

string result;

Console.WriteLine("==============================================================================================");


ArrayList arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add("salam");
arrayList.Add("new");

arrayList.RemoveAt(2);


foreach (var item in arrayList)
{

    Console.WriteLine(item);
}




arrayList.AddRange(keyValues);


foreach (var item in arrayList)
{

    Console.WriteLine(item);
}




arrayList.Clear();

foreach(var item in arrayList)
{

    Console.WriteLine(item);
}

 
Console.WriteLine("==============================================================================================");

//SortedList of int keys, string values 
SortedList<int, string> numberNames = new SortedList<int, string>();
numberNames.Add(3, "uc");
numberNames.Add(1, "1");
numberNames.Add(2, "iki");
numberNames.Add(4, "dort");
numberNames.Add(10, "on");
numberNames.Add(5, "bes");


foreach (var item in numberNames)
{

    Console.WriteLine(item);
}






