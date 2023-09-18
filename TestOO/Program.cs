// See https://aka.ms/new-console-template for more information

using TestOO;

Student s1 = new Student("Ole", 25, "Datamatiker", "12121212", 1); //argumenter
Student s2 = new Student("Peter", 27, "Laborant", "13131313", 3);

s1.PrintInfo();
s2.PrintInfo();

//string n = s1.Name; //Kalder get delen på propertien

s1.Name = "Susanne"; //kalder set delen på propertien

Console.WriteLine($"Student navn { s1.Name } skal betale { s1.CostPrPrint()   }  ");
Console.WriteLine($"Student navn { s2.Name } skal betale { s2.CostPrPrint()  }  ");
