int [,] mtrx=new int[3,3]{
    {10,20,30},
    {56,76,12},
    {23,45,87}
};

Console.WriteLine("Rectangule Array Elements");

for(int i=0;i<3;i++){
    Console.WriteLine("\n");
    for(int j=0;j<3;j++){
          Console.Write(mtrx[i, j] + "\t");
    }
}
    

int [,] monthTimeSheet=new int [4,7]{
    { 6,5,8,3,4,5,4},
    { 4,7,5,4,4,6,7},
    { 8,7,6,8,7,6,9},
    { 2,6,8,7,9,6,5}
};

Console.WriteLine( "\n\nMy Montly working hours Timesheet");

string [] days={ "Mon", "Tues", "Wed", "Thurs", "Fri","Sat", "Sun"};

for(int i=0;i<7;i++){

    Console.Write("\t"+days[i] + "\t");
}
string []weeks= {"Week1", "week2", "week3", "week4"};

for(int week=0;week<4;week++){
    Console.WriteLine("\n");
    Console.WriteLine( "\n"+weeks[week]);
    for(int day=0;day<7;day++){
          Console.Write( "\t"+   monthTimeSheet[week, day] + "\t");
    }
}
