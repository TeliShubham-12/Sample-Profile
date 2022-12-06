using System.Text;
using System.Collections.Generic;

string str1;
string str2 = "welcome to Transflowre";
string str3 = "Hello World!";
string str4 = string.Empty;
string str5 = null;
char[] letters = {'A','B','C'};
string str6 = new string(letters);
string names = "kamlesh\nrutuja\nTanaya";
Console.WriteLine(names);
string msg = "wellcome to \"Transflower\"world";
Console.WriteLine(msg);
string path = @"C:\Users\Transflower\Document\";
Console.WriteLine(path);
string msg1 = @"My Daughter name was ""Tanaya.""";
Console.WriteLine(msg1);
string name = "Sameer Pande";
string location="pune";
string user= string.Format("Name:{0},Location:{1}",name,location);
Console.WriteLine(user);
string name1 = "Sameer Pande";
for(int i=0 ;i<name.Length;i++){
    Console.Write(name[i]);

}
string firstname ="Kamalesh";
string lastname="Pande";
string Location="Pune";
string name2= firstname+ " "+lastname;
Console.WriteLine(name);
string userInfo =string.Format("Name:{0},Location:{1}",name, location);
Console.WriteLine(userInfo);
string name3= "Kamlesh\nRutuja\nTanaya";
Console.WriteLine(names);
string msg2 ="Wlcome to\"transflower World";
Console.WriteLine(msg);
string path1=@"C:\User\Transflower\Document";
Console.WriteLine(path);
string msg3 =@"Hi Guest,Welcome to Transflower World Learning Made Easy";
Console.WriteLine(msg);

string msg4 = @"Her name was ""tanaya.""";
Console.WriteLine(msg1);
Console.WriteLine("\nPressEnter Key to Exit...");
Console.WriteLine();
