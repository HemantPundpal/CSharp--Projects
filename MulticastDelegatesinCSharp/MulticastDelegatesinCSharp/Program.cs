using System;

public delegate void SampleDelegate();

public delegate int SampleDelegateWithReturnType();

public delegate void SampleDelegateHavingOutParameter(out int Number);

class Program
{
    static void Main()
    {
        SampleDelegate delegate1, delegate2, delegate3, delegate4;
        delegate1 = new SampleDelegate(SampleMethodOne);
        delegate2 = new SampleDelegate(SampleMethodTwo);
        delegate3 = new SampleDelegate(SampleMethodThree);

        delegate4 = delegate1;
        delegate4 -= delegate1;
        //del4(); //Exception as del4 is empty. 
        delegate4 = delegate1 + delegate2 + delegate3 - delegate2;
        delegate4(); //test
        delegate4 -= (delegate1 + delegate3);
        //del4(); //Exception as del4 is empty
        delegate4 = delegate1;
        delegate4 += delegate1;
        delegate4 += delegate2 + delegate3;
        delegate4 += delegate4;
        delegate4(); //test

        SampleDelegateWithReturnType delegateWithReturnType = new SampleDelegateWithReturnType(SampleMethodWithReturnType1);
        delegateWithReturnType += SampleMethodWithReturnType2;
        int ReturnValue = delegateWithReturnType();
        Console.WriteLine($"Return value is - {ReturnValue}"); //Last function return value is received.

        SampleDelegateHavingOutParameter delegateHavingOutParameter = new SampleDelegateHavingOutParameter(SampleMethodHavingOutParameter1);
        delegateHavingOutParameter += SampleMethodHavingOutParameter2;
        int OutParameterValue;
        delegateHavingOutParameter(out OutParameterValue);
        Console.WriteLine($"Out parameter value is - {OutParameterValue}"); //Last function out parameter value is received.



        Console.ReadKey();
    }
    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne invoked");
    }
    public static void SampleMethodTwo()
    {
        Console.WriteLine("SampleMethodTwo invoked");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree invoked");
    }

    /* Sample method with return type. */
    public static int SampleMethodWithReturnType1()
    {
        return 1;
    }

    public static int SampleMethodWithReturnType2()
    {
        return 2;
    }

    /* Sample method with out parameter. */
    public static void SampleMethodHavingOutParameter1(out int Number)
    {
        Number = 1;
    }

    public static void SampleMethodHavingOutParameter2(out int Number)
    {
        Number = 2;
    }
}

