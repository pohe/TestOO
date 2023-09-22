// See https://aka.ms/new-console-template for more information

using TestOO;

Student s1 = new Student("Ole", 25, "Datamatiker", "12121212", 1); //argumenter

Console.WriteLine("Udskrift af tostring " + s1);
Console.WriteLine($"StudentId for {s1.Name}  er {s1.StudentID}" );

Student s2 = new Student("Peter", 27, "Laborant", "13131313", 3);
Console.WriteLine($"StudentId for {s2.Name}  er {s2.StudentID}");


//s1.PrintInfo();
//s2.PrintInfo();

////string n = s1.Name; //Kalder get delen på propertien

//s1.Name = "Susanne"; //kalder set delen på propertien

//Console.WriteLine($"Student navn { s1.Name } skal betale { s1.CostPrPrint()   }  ");
//Console.WriteLine($"Student navn { s2.Name } skal betale { s2.CostPrPrint()  }  ");


Car c1 = new Car("VW", "AB 121212");
Car c2 = new Car("Volvo", "AC144444");

Car c3 = new Car("AB44444");

Car c4 = new Car();

c1.RegNo = "FG 23232";

c1.PrintInfo();

Human jens = new Human("Jens Jensen", 1.8, 82.5);
string navn = jens.Name;

jens.Name = "Ib";
double jensHeight = jens.Height;

jens.Height = 1.99;



//SimpleMath simpleMath = new SimpleMath();
int resultat = SimpleMath.Add(int.Parse(Console.ReadLine()), 13);