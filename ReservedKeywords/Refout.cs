namespace Keywords
{
    
}
public class DemoClass
{
    public static void swap(ref int n1,ref int n2)
    {int temp =n1; n1=n2; n2=temp;

    }
    public static void Calculate (float radius,out float area,out float circum)
    {
        area=3.14f * radius * radius;
        circum=2*3.14f * radius;
        
    }
    public static void main ()
    {
        int x=10, y=20;
        swap (ref x ,ref y);
        float area, circum;
        Calculate (5, out area,out circum);
    }
    
}