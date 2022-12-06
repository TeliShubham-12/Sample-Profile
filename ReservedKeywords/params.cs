namespace Keywords;

public  class Test{
public static void ViweNames (params string [] names)
{
    foreach( string name in names){
        Console.WriteLine("names ="+ name);
    }
}
}
