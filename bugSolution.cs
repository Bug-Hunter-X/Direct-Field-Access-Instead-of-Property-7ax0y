public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set
        {
            // Add validation or any other logic here
            if (value < 0) 
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative.");
            }
            _myField = value; 
        }
    }

    public void MyMethod()
    {
        // Correct way to modify the field - using the property
        MyProperty = 10; 
    }
}