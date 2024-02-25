#region Person Class
using Homework_Inheritance;
using System.Data;
using System.Security.Claims;

//Person person = new()
//{
//    id = 1,
//    fullName = "test",
//    age = 21,
//    position = "student"
//};


//Person person = new(1, "test1", 22, "student");

//Console.WriteLine(person1.fullName);


//Person person = new Person("Hello World","Test One");
Person[] GetAllPeople()
{ 
    Person person1 = new()
    {
        id = 1,
        fullName = "test1",
        age = 22,
        position = "student"
    };

    Person person2 = new()
    {
        id = 2,
        fullName = "test2",
        age = 32,
        position = "student"
    };

    Person person3 = new()
    {
        id = 3,
        fullName = "test3",
        age = 13,
        position = "student"
    };

    Person person4 = new()
    {
        id = 4,
        fullName = "test4",
        age = 25,
        position = "student"
    };


    Person[] people = {person1,person2, person3, person4};
    return people;
}
//Person[] GetAllPeople(Person[] people)
//{
//    return people;
//}
//var allPeople = GetAllPeople(people);

//if(result != null)
//{
//    string response = $"Id:{result.id}, fullName:{result.fullName}, Age:{result.age}, Position:{result.position}";
//    Console.WriteLine(response);
//}
//else
//{
//    Console.WriteLine("Data Not Found");
//}


//var result1 = result != null ? $"Id:{result.id}, fullName:{result.fullName}, Age:{result.age}, Position:{result.position}" : "Data Not Found";

//Console.WriteLine(result1);


Person FindPersonById(Person[] people, int id)
{
    return people.FirstOrDefault(m=> m.id == id);
}

void ShowPersonById(Person person)
{
    if(person != null)
    {
        string response = $"Id:{person.id}, fullName:{person.fullName}, Age:{person.age}, Position:{person.position}";
        Console.WriteLine(response);
    }
    else
    {
        Console.WriteLine("Data Not Found");
    }
}

//ShowPersonById(FindPersonById(GetAllPeople(), 1));

void ShowAllPeople(Person[] datas)
{
    foreach(Person person in datas)
    {
        string response = $"Id:{person.id}, fullName:{person.fullName}, Age:{person.age}, Position:{person.position}";
        Console.WriteLine(response);
    }
}

//ShowAllPeople(GetAllPeople());




Person[] GetPeopleByName(Person[] people,string name)
{
    return people.Where(m=>m.fullName == name).ToArray();
}

void ShowPeopleByName(Person[] people)
{
    foreach (Person person in people)
    {
        string response = $"Id:{person.id}, fullName:{person.fullName}, Age:{person.age}, Position:{person.position}";
        Console.WriteLine(response);
    }
}

//ShowPeopleByName(GetPeopleByName(GetAllPeople(), "test3"));

#endregion

#region Animal Class
//Animal animal = new()
//{
//    id = 1,
//    name = "Tiger"
//};

//Console.WriteLine(animal.name);

//Bird bird = new()
//{
//    id = 1,
//    name = "Eagle",
//    age = 3,
//};

//Console.WriteLine(bird.name);

//bird.Sound();

//Fish fish = new();

#endregion

#region Assignments
//CustomMath adinda class yaradin, hemin clasin icinde ashagidaki methodlar olacaq. Hemin methodlari proqram classda cagirib ishledin. 
//     1)Method array qebul edir, arrayin icerisindeki tek ededlerin cemini tapin.
//     2)Methoda gelen ededin tek ve ya cut olub olmamasini gosterin.
//     3) Methoda gelen arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
//     4) Methoda n ededi gelir, 1-den n ededine qeder olan ededlerin hasilini tapin.

CustomMath customMath = new();

int[] nums = { 1, 2, 3, 4, 5};

int n = 4;

//Console.WriteLine(customMath.SumOfOddNumbers(nums));

//customMath.OddOrEvenNumber(n);

//Console.WriteLine(customMath.SquareOfSumOfNumbers(nums));

//Console.WriteLine(customMath.Multiplier(n));

//Employee adinda class yaradin, Class -in id, name, surname, address, email, age fieldleri olacaq. Proqram.cs - de ashagidaki methodlari      yazin. 
//    1)  Yashi methoda parametr kimi gelen yashdan boyuk olan 
//employee -lerin  siyahisini qaytaran method.
//    2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.
//    3)  Butun Emloyeelerin yashlarinin cemini qaytaran method.
//    4)  Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

Employee employee1 = new()
{
    id = 1,
    name = "employee1",
    surname = "surname1",
    address = "address1",
    email = "email1@mail.ru",
    age = 30
};
Employee employee2 = new()
{
    id = 2,
    name = "employee2",
    surname = "surname2",
    address = "address2",
    email = "email2@mail.ru",
    age = 20
};
Employee employee3 = new()
{
    id = 3,
    name = "employee3",
    surname = "surname3",
    address = "address3",
    email = "email3@mail.ru",
    age = 33
};
Employee employee4 = new()
{
    id = 4,
    name = "employee4",
    surname = "surname4",
    address = "address4",
    email = "email4@mail.ru",
    age = 27
};

Employee[] employees = {employee1, employee2, employee3, employee4};

//First Method
Employee[] ListOfPeopleByAge(Employee[] employees, int age)
{
    return Array.FindAll(employees, m => m.age > age);
}
void ShowListOfPeople(Employee[] data)
{
    foreach(Employee item in data)
    {
        Console.WriteLine($"Id:{item.id}, Name:{item.name}, Surname:{item.surname}, Address:{item.address}, Email:{item.email}, Age:{item.age}");
    }
}

//ShowListOfPeople(ListOfPeopleByAge(employees,20));

//Second Method

Employee[] ListOfEmployeesFrom20To30(Employee[] employees)
{
    return Array.FindAll(employees, m => m.age > 20 && m.age < 30);
}

//ShowListOfPeople(ListOfEmployeesFrom20To30(employees));


//Third Method

int SumOfAges(Employee[] data)
{
    int sum = 0;
    foreach(Employee item in data)
    {
        sum += item.age;
    }
    return sum;
}

//Console.WriteLine(SumOfAges(employees));


//Forth Method

Employee[] GetEmployeeByEmail(Employee[] employees,string email)
{
   return Array.FindAll(employees,m=>m.email == email);
}

//ShowListOfPeople(GetEmployeeByEmail(employees, "email1@mail.ru"));



#endregion