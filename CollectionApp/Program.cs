using TFLCollections;
Student [] students={
    new Student{
        BirthDate = new DateTime(1998, 3, 12),
        Name = "Akshay Girmal",
        Location = "Mumbai",
        Id = 45
    },
    
    new Student{ BirthDate = new DateTime(1992, 6, 22),
                 Name = "Ramya Datta",
                 Location = "Kolkatta",
                Id = 47
    },
    new Student{ BirthDate = new DateTime(1988, 3, 12),
                Name = "Manisha Patil",
                Location = "Pune",
                Id = 15
}
};
foreach ( Student student in students){
     Console.WriteLine(student.Id + "  " + student.Name + "  " +student.Location);
}
    foreach (Student student in students)
    {
        Console.WriteLine(student.Id + "  " + student.Name + "  " +student.Location);
}
    