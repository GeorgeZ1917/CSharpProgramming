//Main.cs

using System;
using System.Collections.Generic;


public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Hello World");
        int[] numbers1 = { 1, 3, 0, 0, -4, 10, 5, 3, 9, -7, -7, 5, 1, 0, -10 };
        int[] numbers2 = { 1, 3, 0, 0, -4, 10, 5, 3, 9, -7, -7, 5, 1, 0, -10 };
        MyClass.SelectionSort(numbers1);
        MyClass.printArray(numbers1);
        MyClass.InsertionSort(numbers2);
        MyClass.printArray(numbers2);

        Random r = new Random();

        int[] longArray = new int[100];
        for (int i = 0; i < 100; i++)
        {
            longArray[i] = r.Next(-100, 100);
        }

        MyClass.SelectionSort(longArray);
        MyClass.printArray(longArray);

        MyClass obj = new MyClass(5);
        obj.getVal();
        obj.setVal(10);
        obj.getVal();

        MyClass.testData();

        String aString = "The fisrt string";
        String anotherString = "The second string";

        Console.WriteLine("Are the strings equal? {0}", aString.Equals(anotherString));

        DerivedClass derObj = new DerivedClass(5);
        MyClass myObj = new MyClass(3);
        derObj.virtMeth();
        myObj.virtMeth();
        Console.WriteLine("Example values: {0:f}, {1:n}, {2:n}", 1050, 3014, 1070004);
        string myString = "Example string";
        string anotherStringTwo = "Another string";
        string sameString = "Example string";
        int anInt = 123456789;
        int anotherInt = 987654321;
        int sameInt = 987654321;
        Console.WriteLine("myString equals anotherStringTwo: {0}", myString == anotherStringTwo);
        Console.WriteLine("myString equals anotherStringTwo: {0}", myString.Equals(anotherStringTwo));
        Console.WriteLine("myString equals sameString: {0}", myString.Equals(sameString));
        Console.WriteLine("myString without \'r\': {0}", myString.Replace("r", ""));
        Console.WriteLine("anInt is equal to anotherInt: {0}", anInt.Equals(anotherInt));
        Console.WriteLine("anotherInt is equal to sameInt: {0}", anotherInt.Equals(sameInt));
        foreach (char val in myString)
        {
            Console.WriteLine(val);
        }
        
        List <double> doubleList = new List<double> ();
        for (int i = 0; i < 10; i ++ )
        {
            doubleList.Add((double) i * i * 0.50);
        }
        foreach ( double val in doubleList)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine("\n");
        foreach (double val in doubleList)
        {
            switch ((int) val)
            {
                case 2:
                    Console.WriteLine("The value is 2.");
                    break;
                case 8:
                    Console.WriteLine("The value is 8.");
                    break;  
                case 18:
                case 32:
                    Console.WriteLine("The value is either 18 or 32.");
                    break;                    
            }
        }
        int [] myArray = new int [] {1, 6, 0, 0, 4, 3, 7, 9, 1, 10};
        Array.Sort(myArray);
        foreach (int val in myArray)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine("\n");
        int [] theArray = MyClass.returnArray();
        Array.Sort(theArray);
        foreach (int val in theArray)
        {
            Console.Write(val + " and ");
        }
        MethodsClass.partialParams(3, "A string", 3.1415f, 2.718f);
        MyClass newObjMyClass = new MyClass (5);
        bool theFlag = false;
        int refInt = 8;
        MethodsClass.optionalParams (ref refInt, ref newObjMyClass);
        Console.WriteLine("refInt after reference passing: {0}.", refInt);
        Console.WriteLine("newObjMyClass.val after reference passing: {0}.", newObjMyClass.getVal(5));
        MethodsClass.optionalParams (ref refInt, ref newObjMyClass, theFlag);

        LinkedList LinkedList = new LinkedList();
        headNode.next = null;
        headNode.data = 5;

        LinkedList.insertElement(headNode, 2);
        LinkedList.insertElement(headNode, 1);
        LinkedList.insertElement(headNode, 7);
        LinkedList.insertElement(headNode, 9);
        LinkedList.insertElement(headNode, 12);
        LinkedList.insertElement(headNode, 6);
        LinkedList.insertElement(headNode, 20);
        LinkedList.printList(headNode);

        LinkedList newNode = LinkedList.findNode(headNode, 7);

        Console.WriteLine("Value of newNode.data is {0}.", newNode.data);
        LinkedList.printList(headNode);

        (int intVal, float floatVal, string stringVal) myTuple = (42, 3.1415f, "Hello World.");
        Console.WriteLine("The float value of myTuple is {0}:", myTuple.floatVal);
        (int val, string theString) tupleFromMethod = MethodsClass.returnTuple();
        Console.WriteLine("The string value of tupleFromMethod is: {0}", tupleFromMethod.theString);


        MyClass myClassTwo = new DerivedClassTwo();
        MyClass myClassThree = new DerivedClassThree();
        myClassTwo.derivedClassMethod();
        myClassThree.derivedClassMethod();


        PropertiesClass propObj = new PropertiesClass();
        PropertiesClass propObj2 = new PropertiesClass(42, "Hello, World!", false);
        try
        {
            propObj.intProp = 50_00;
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error setting the integer data: " + ex.Message);
        }
        propObj.stringProp = "String data.";
        propObj.boolProp = true;
        Console.WriteLine("Integer value of propObj: {0}, string value of propObj: '{1}', bool value of objProp: {2}.", propObj.intProp, propObj.stringProp, propObj.boolProp);
        Console.WriteLine("Integer value of propObj2: {0}, string value of propObj2: '{1}', bool value of propObj2: {2}.", propObj2.intProp, propObj2.stringProp, propObj2.boolProp);
        Console.WriteLine("Readonly value from PropertiesClass: {0}.", propObj.readVar.ToString());

        DerivedClassThree newDerivedObj = new DerivedClassThree(42, "Derived class three string.");
        Console.WriteLine("The string of 'newDerivedObj' set through a property is: {0}", newDerivedObj.stringData);
        
        Console.ReadKey();
    }
}
