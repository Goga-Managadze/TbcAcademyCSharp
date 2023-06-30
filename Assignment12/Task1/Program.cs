// See https://aka.ms/new-console-template for more information
using System.Collections;


//Array
string[] countriesArray = {"Georgia", "France"};
int count = countriesArray.Count();
Console.WriteLine("Number of elements in array: " + count);
Array.Clear(countriesArray, 1, 1);


foreach (var country in countriesArray)
{
    Console.WriteLine(country);
}


//ArrayList
var arrList = new ArrayList();
int[] numbers = {1, 2, 3, 4, 5, 6, 7,};
arrList.Add("animal");
arrList.Add("plant");
arrList.Add("thing");
arrList.AddRange(numbers);
arrList.RemoveAt(2);
arrList.Remove(6);
Console.WriteLine(arrList.Contains(1));
Console.WriteLine("Capacity: " + arrList.Capacity);


foreach (var country in arrList)
{
    Console.WriteLine(country);
}


//List
Console.WriteLine("List");
List<int> list = new List<int>();

list.Add(8);
list.Add(9);
list.AddRange(numbers);
list.Insert(0, 10);
list.InsertRange(2, numbers);
list.RemoveAt(2);
list.Remove(9);
list.RemoveRange(2, 5);
list.Sort();
Console.WriteLine(list.Count);
Console.WriteLine(list.Contains(3));
list.Clear();

foreach (var l in list)
{
    Console.WriteLine(l);
}


//Dictionary
Console.WriteLine();
Console.WriteLine("Dictionary");
var dictionary = new Dictionary<int, string>();
dictionary.Add(1, "book1");
dictionary.Add(2, "book2");
dictionary.Add(3, "book3");
Console.WriteLine(dictionary.Count);
Console.WriteLine("Value of key 1: " + dictionary[1]);

string result;
if (dictionary.TryGetValue(1, out result))
{
    Console.WriteLine(result);
}

var keyValue = dictionary.ElementAt(1);
Console.WriteLine("Key: " + keyValue.Key);
Console.WriteLine("Value: " + keyValue.Value);

Console.WriteLine(dictionary.ContainsKey(1));
Console.WriteLine(dictionary.ContainsValue("book1"));
Console.WriteLine(dictionary.Contains(new KeyValuePair<int, string>(2, "book2")));

dictionary.Remove(1);

foreach (var d in dictionary)
{
    Console.WriteLine(d);
}


//SortedList
Console.WriteLine();
Console.WriteLine("SortedList");

SortedList<int, string> bookNumbers = new SortedList<int, string>();
bookNumbers.Add(1, "Book1");
bookNumbers.Add(2, "Book2");
bookNumbers.Add(3, "Book3");
Console.WriteLine(bookNumbers.IndexOfKey(1));
Console.WriteLine(bookNumbers.IndexOfValue("Book2"));
bookNumbers.Remove(1);
Console.WriteLine(bookNumbers.Count());

foreach (var b in bookNumbers)
{
    Console.WriteLine(b);
}

//Stack
Console.WriteLine();
Console.WriteLine("Stack");

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Pop();
Console.WriteLine("Stack Peek: " + stack.Peek());
Console.WriteLine(stack.Contains(1));

foreach (var s in stack)
{
    Console.WriteLine(s);
}


//Queue
Console.WriteLine();
Console.WriteLine("Queue");

Queue<int> numbersQueue = new Queue<int>();
numbersQueue.Enqueue(1);
numbersQueue.Enqueue(2);
numbersQueue.Enqueue(3);
numbersQueue.Enqueue(4);
numbersQueue.Dequeue();
Console.WriteLine("Peek: " + numbersQueue.Peek());
Console.WriteLine(numbersQueue.Contains(2));

foreach (var num in numbersQueue)
{
    Console.WriteLine(num);
}


//HashTable
Console.WriteLine();
Console.WriteLine("HashTable");

Hashtable number = new Hashtable();
number.Add(1, "erti");
number.Add(2, "ori");
number.Add(3, "sami");
number.Remove(3);
Console.WriteLine(number.Contains(1));

foreach (var h in number)
{
    Console.WriteLine(h);
}