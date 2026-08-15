int monday = (int)DaysOfWeak.Thursday;


Console.WriteLine(monday);


Console.WriteLine($"Enum Directly: {DayOfWeek.Monday}");
Console.WriteLine($"Enum Casted:{(int)DayOfWeek.Monday }");

DaysOfWeak mondayEnum = (DaysOfWeak)Enum.Parse(typeof(DaysOfWeak), "Monday");
DaysOfWeak mondayEnum2 = Enum.Parse<DaysOfWeak>("Monday");
Console.WriteLine(mondayEnum);
Console.WriteLine(mondayEnum2);


DaysOfWeak mondayEnum3;
bool parseSucceed =  Enum.TryParse("Thursday", out mondayEnum3);
Console.WriteLine($"Enum {(parseSucceed ? "Was Parsed" : "Wasn't parsed")}: {mondayEnum3}");

DaysOfWeak1 mondayEnum4;
bool parseSucceed1 =  Enum.TryParse("Hello", out mondayEnum4);
Console.WriteLine($"Enum {(parseSucceed1 ? "Was Parsed" : "Wasn't parsed")}: {mondayEnum4}");

Console.WriteLine("\nAll Enum Values:");
foreach (DaysOfWeak day in Enum.GetValues(typeof(DaysOfWeak)))
{
    Console.WriteLine((int)day + " " + day);
}
Console.WriteLine("\nAll Enum Values1:");
foreach (DaysOfWeak1 day in Enum.GetValues(typeof(DaysOfWeak1)))
{
    Console.WriteLine((int)day + " " + day);
}

DaysOfWeak invalidDay = (DaysOfWeak)8;
Console.WriteLine($"Invalid Enum Value: {invalidDay}");
DaysOfWeak validDay = (DaysOfWeak)3;
Console.WriteLine($"Valid Enum Value: {validDay}");


// Flags
Permissions readWrite = Permissions.Read | Permissions.Write | Permissions.Execute;

Console.WriteLine($"RW: {readWrite}");

bool canRead = (readWrite & Permissions.Read) == Permissions.Read;
bool canWrite = (readWrite & Permissions.Write) == Permissions.Write;
bool canExecute = (readWrite & Permissions.Execute) == Permissions.Execute;

Console.WriteLine($"Can Read: {canRead}");
Console.WriteLine($"Can Write: {canWrite}");
Console.WriteLine($"Can Execute: {canExecute}");


[Flags]
enum Permissions
{
    None = 0,    // 0000
    Read = 1,    // 0001
    Write = 2,   // 0010
    Execute = 4, // 0100
}

enum DaysOfWeak
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
};


enum DaysOfWeak1
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
};