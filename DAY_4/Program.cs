// See https://aka.ms/new-console-template for more information
public class Counter
{
    //non static variable
    public int instanceCount = 0; // Each object of Counter class will have its own copy of instanceCount variable
    //static variable
    public static int count = 0; // Any point of time we can access this static variable using class name Counter.count
    //constructor
    public Counter()
    {
        count++;//post increment- if we rement count value using any object of Counter class it will be reflected in all other objects
    }

    //non static method which can access both static and non static variables
    public void DisplayCount()
    {
        Console.WriteLine("Count: " + count);
    }
    //static method
    public static void StaticDisplayCount() // static method can access only static variables
    {
        Console.WriteLine("Static Count: " + count);
    }

}
