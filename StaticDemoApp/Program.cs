using Training;

Student std1=new Student(12,"Sameer Kane", "BCS","samir.kQgmail.com");
Student std2=new Student(14, "Manisha pant", "BE","manisha.p@gmail.com");
Student std3=new Student(23,"Kiran Mane", "MCA");
Student std4=new Student();


Console.WriteLine(std1);
std1.ShowStatus();
Console.WriteLine(std2);
std2.ShowStatus();
Console.WriteLine(std3);

std3.ShowStatus();
Console.WriteLine(std4);

std4.ShowStatus();

int noOfInstances=Student.GetCount();
Console.WriteLine("No of object of Student class ={0}", noOfInstances);

Console.WriteLine("Hello, World!");