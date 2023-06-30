using System.Collections;
using System.Collections.Generic;

// ArrayList >>
Console.WriteLine("ArrayList:");
var array = new ArrayList();
array.Add(5);
array.Add("Anri");

array.Remove(5);
array.Insert(0,"Managadze");
array.InsertRange(2, new ArrayList() {"Developer","TBC"});

foreach (var item in array)
{
    Console.WriteLine(item);
}
Console.WriteLine(array.Capacity);
Console.WriteLine(array.Count);
// <<

// List >>
Console.WriteLine("List:");
List<string> list = new List<string>();
list.Add("5");
list.Add("Anri");

list.Remove("5");
list.Insert(0, "Managadze");
list.InsertRange(2, new List<string>() { "Developer", "TBC" });
list.Sort();
foreach (var item in list)
{
    Console.WriteLine(item);
}
//<<

// Dictionary >>
Console.WriteLine("Dictionary:");
var dictionary = new Dictionary<int, string>();
dictionary.Add(1,"5");
dictionary.Add(2,"Anri");

dictionary.Remove(1);
dictionary.ContainsKey(2);

foreach (var item in dictionary)
{
    Console.WriteLine(item);
}
//<<

// SortList >>
Console.WriteLine("SortList:");
var sortList = new SortedList<int, string>();
sortList.Add(5,"Five");
sortList.Add(3,"Three");
sortList.Add(1,"One");
sortList.Add(2,"Two");
sortList.Add(4,"Four");

sortList.Remove(5);

//sortList.Clear();

foreach (var item in sortList)
{
    Console.WriteLine(item);
}
Console.WriteLine(sortList.IndexOfKey(1));
//<<

// SortList >>
Console.WriteLine("HashSet:");
var hashSet = new HashSet<int>();
hashSet.Add(5);
hashSet.Add(2);
hashSet.Add(8);
hashSet.Add(1);
hashSet.Add(3);

hashSet.Remove(3);
hashSet.ToString();


foreach (var item in hashSet)
{
    Console.WriteLine(item);
}
//<<

// Hashtable >>
Console.WriteLine("Hashtable:");
var hashTable = new Hashtable();
hashTable.Add(5, "Five");
hashTable.Add(3, "Three");
hashTable.Add(1, "One");
hashTable.Add(2, "Two");
hashTable.Add(4, "Four");

hashTable.Remove(5);
//<<

// Stack >>
Console.WriteLine("Stack:");
var stack = new Stack<int>();
stack.Push(5);
stack.Push(2);
stack.Push(8);
stack.Push(1);
stack.Push(3);

stack.Pop();

foreach (var item in stack)
{
    Console.WriteLine(item);
}

Console.WriteLine(stack.Peek());
//<<

// Queue >>
Console.WriteLine("Queue:");
var queues = new Queue<int>();
queues.Enqueue(5);
queues.Enqueue(2);
queues.Enqueue(8);
queues.Enqueue(1);
queues.Enqueue(3);

queues.Dequeue();


foreach (var item in queues)
{
    Console.WriteLine(item);
}

Console.WriteLine(queues.Peek());
Console.WriteLine("Queues Count: " + queues.Count());
//<<