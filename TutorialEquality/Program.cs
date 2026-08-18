var myClass = new MyClass { NumericValue = 1, StringValue = "Hello Class" };
var myClass1 = new MyClass{ NumericValue = 1, StringValue = "Hello Class" };

Console.WriteLine("check if class equals to same class?");
Console.WriteLine(myClass == myClass1);
Console.WriteLine(myClass.Equals(myClass1));
Console.WriteLine(object.Equals(myClass, myClass1));

var myStruct = new MyStruct { NumericValue = 1, StringValue = "Hello Struct" };
var myStruct1 = new MyStruct{ NumericValue = 1, StringValue = "Hello Struct" };
Console.WriteLine("check if struct equals to struct?");
// Console.WriteLine(myStruct == myStruct1);
Console.WriteLine(myStruct.Equals(myStruct1));
Console.WriteLine(object.Equals(myStruct, myStruct1));


var myClassE = new MyClassWithEquality { NumericValue = 1, StringValue = "Hello Class" };
var myClassE1 = new MyClassWithEquality{ NumericValue = 1, StringValue = "Hello Class" };

Console.WriteLine("check if class equals to same class?");
Console.WriteLine(myClassE == myClassE1);
Console.WriteLine(myClassE.Equals(myClassE1));
Console.WriteLine(object.Equals(myClassE, myClassE1));

public class MyClass
{
    public int NumericValue { get; set; }
    public string StringValue { get; set; }
};

public struct MyStruct
{
    public int NumericValue { get; set; }
    public string StringValue { get; set; }
}


class MyClassWithEquality
{
    public int NumericValue { get; set; }
    public string StringValue { get; set; }

    public override bool Equals(object obj)
    {
        if ( obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (MyClassWithEquality)obj;
        return NumericValue == other.NumericValue && StringValue == other.StringValue;
    }
    
    public override int GetHashCode()
    {
        return NumericValue.GetHashCode() ^ StringValue.GetHashCode();
    }

    public static bool operator ==(MyClassWithEquality left, MyClassWithEquality right)
    {
        return left.Equals(right);
    }
    public static bool operator !=(MyClassWithEquality left, MyClassWithEquality right)
    {
        return !left.Equals(right);
    }
    
}