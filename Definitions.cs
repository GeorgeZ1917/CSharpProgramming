// Definitions.cs


using System;


public class MyClass
{
    protected int val;
    public MyClass()
    {
        ;
    }
    public MyClass(int i)
    {
        val = i;
    }
    public void setVal(int i)
    {
        val = i;
    }
    public void getVal()
    {
        Console.WriteLine("The value of val is {0}", this.val + ".");
    }
    public int getVal(int valX)
    {
        return val;
    }
    public static void SelectionSort(int[] array)
    {
        int min, temp;
        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }
    }

    public static void InsertionSort(int[] array)
    {
        int i, key;
        for (int j = 1; j < array.Length; j++)
        {
            key = array[j];
            i = j;
            while (i > 0 && (key < array[i - 1]))
            {
                array[i] = array[i - 1];
                i--;
            }
            array[i] = key;
        }
    }

    public static void printArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element.ToString() + " ");
        }
        Console.WriteLine("");
    }
    public static void testData()
    {
        //System.Int32 intObj = new System.Int32();
        //intObj = 50;
        string strObj = "String object.";
        Console.WriteLine("The minimum value of intObj is {0} ", int.MinValue);
        Console.WriteLine("The value of strObj is {0} ", strObj);
    }
    public virtual void virtMeth()
    {
        Console.WriteLine("val: " + val.ToString());
    }
    public static int [] returnArray()
    {
        int [] newArray = new int [] {2, 7, 9, 2, 10, 2, 2, 16, 90, 61, 7, 1, 6, 8, 7, 4};
        return newArray;
    }
    public virtual void derivedClassMethod()
    {
        Console.WriteLine("Default virtual implementation.");
    }
}

public class DerivedClass : MyClass
{
    private int valX;
    public DerivedClass(int i)
    {
        valX = i;
    }
    public override void virtMeth()
    {
        Console.WriteLine("valX * valX: " + (valX * valX).ToString());
    }
}

public class DerivedClassTwo : MyClass
{
    public float dataDerived;
    public override void derivedClassMethod()
    {
        Console.WriteLine("Inside derived method from DerivedClassTwo");
    }
}

public class DerivedClassThree : MyClass
{
    public float dataDerived;
    private string dataString;
    public string stringData
    {
        get { return dataString; }
        set
        {
            if (value != null)
            {
                dataString = value;
            }
            else
            {
                throw new Exception ("Cannot set the value to an empty string.");
            }
        }
    }
    public DerivedClassThree ()
    {
        ;
    }
    public DerivedClassThree (int dataInt, string dataString)
        :base (dataInt)    
    {
        stringData = dataString;
    }
    public override void derivedClassMethod()
    {
        Console.WriteLine("Inside derived method from DerivedClassThree");
    }
}


public class MethodsClass
{
    public static void partialParams (int val, string myString, params float [] vals)
    {
        Console.WriteLine("val squared: {0}", val * val);
        Console.WriteLine("myString expanded: " + myString + ", and that's all, folks!");
        Console.Write("The params arguments: ");
        foreach (float num in vals)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");
    }
    public static void optionalParams (ref int val, ref MyClass obj, bool flag = false)
    {
        val *= val;
        obj.setVal(10);
        flag = true;
    }
    public static (int val, string stringVar) returnTuple()
    {
        return (42, "Tuple string");
    }
}


public class PropertiesClass
{
    private int intData;
    private string stringData;
    private bool boolData;
    public int intProp
    {
        get { return intData; }
        set 
        {
            if (value > 10_000)
            {
                throw new Exception ("Cannot set the value; it is greater than 10,000.");
            }
            else
            {
                intData = value;
            }
        }
    }
    public string stringProp
    {
        get { return stringData; }
        set { stringData = value; }
    }
    public bool boolProp { get; set; }
    public PropertiesClass ()
    {
        readVar = 3.141592f;
    }
    public PropertiesClass (int dataInt, string dataString, bool dataBool)
    {
        intData = dataInt;
        stringData = dataString;
        boolData = dataBool;
    }
    public readonly float readVar;
}

public class ExceptionClass
{
    private double val;
    public double ValProp
    {
        get { return val; }
        set { val = value; }
    }
    public ExceptionClass (double val)
    {
        ValProp = val;
    }
    public double division (double val)
    {
        if (val == 0)
        {
            throw new Exception ("Exception thrown: attempted to divide by zero.");
        }
        else
        {
            return val / ValProp;
        }
    }
}


public interface IData
{
    void printData ();
}

public class Linear : IData, ICloneable, IComparable
{
    private float _data;
    public float Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public Linear (float val)
    {
        Data = val;
    }
    public void printData ()
    {
        Console.WriteLine("The linear value of {0} is {1}.", Data, Data);
    }
    public object Clone ()
    {
        return new Linear ( this.Data );
    }
    int IComparable.CompareTo(object obj)
    {
        Linear temp = obj as Linear;
        if (temp != null)
        {
            return this.Data.CompareTo(temp.Data);
        }
        return -2;
    }
}

public class Squared : IData
{
    private float _data;
    public float Data
    {
        get { return _data; }
        set { _data = value; }
    }
    public Squared (float val)
    {
        Data = val;
    }
    public void printData ()
    {
        Console.WriteLine("The squared value of {0} is {1}.", Data, Data * Data);
    }
}
