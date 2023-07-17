// See https://aka.ms/new-console-template for more information

using Task;

try
{
    MyList<int> myList = new MyList<int>();
    int[] array = new int[] { 4, 5, 6, 7, 8 };
    myList.addElement(1);
    myList.addElement(2);
    myList.addElement(3);
    myList.AddRange(array);
    myList.removeElementAt(10);
    myList.removeElement(6);
    myList.removeRange(array);

    foreach (int item in myList)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Count: {myList.elementsCount()}");
    //Console.WriteLine(myList.getElement(5));
    Console.WriteLine(myList.isElementInList(1));

    int lessThanTwo = myList.singleMethod(n => n < 2);
    Console.WriteLine(lessThanTwo);

    int singleOrDefaultFromMyList = myList.singleOrDefaultMethods(n => n > 2);
    Console.WriteLine(singleOrDefaultFromMyList);

    int foundNumber = myList.find(n=> n > 2);
    Console.WriteLine(foundNumber);

    var evenNumbers = myList.whereMethod(n => n % 2 == 0);
    foreach (int num in evenNumbers)
    {
        Console.WriteLine(num);
    }

}
catch (IndexOutOfRangeException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
catch (ArgumentOutOfRangeException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
catch (InvalidOperationException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
