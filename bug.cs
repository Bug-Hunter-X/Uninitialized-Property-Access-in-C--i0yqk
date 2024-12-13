public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized
        int value = MyProperty * 2; 
    }
}