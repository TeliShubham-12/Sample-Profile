namespace Training;
public class Student{
    private int id;
    private string fullName;
    private string qalification;
    private string email;

    private static int count;
    



    public Student(){
        this.id=45;
        this.fullName="Shubham Teli";
        this.qalification="BCS";
        this.email="shubhamteli203@gmail.com";
        Console.WriteLine("constucto is called....");
        count=count+1;

    }   
    public Student(int i, string name, string education){
        this.id=i;
        this.fullName=name;
        this.qalification=education;
        this.email="student@tfl.com";
        count=count+1;

    }

    public Student(int i, string name ,string education, string em){
        this.id=i;
        this.fullName=name;
        this.qalification=education;
        this.email=em;
        count=count+1;

    }

    public  override string ToString()
    {
        string data=string .Format(" {0}, {1}, {2}", this.id, this.fullName, this.qalification);
        return data;

    }
    public void ShowStatus(){
        Console.WriteLine("I am alive");

    }
    public static int GetCount(){
        return count;
    }
}