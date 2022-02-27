

//Сортировка массива
//int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

//int temp;
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = i + 1; j < nums.Length; j++)
//    {
//        if (nums[i] < nums[j])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}

//// вывод
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}
//-------------------------------------------------------------


//Необязательные аргументы в методе
//int a = 10;
//int b = 20;
//int c = a + b;
//string r = "Делить";
//void Mat(int g, string k = "Умножить")
//{
//    Console.WriteLine($"Сумма = {g + g}");
//}
//Mat(c);//Ошибки нет, передаём только один параметр
//Mat(c, r);
//--------------------------------------------------------------


//Выходные параметры, возвращает как return
//void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
//    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
//}

//int area;
//int perimetr;

//GetRectangleData(10, 20, out area, out perimetr);

//Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
//Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60
//----------------------------------------------------------------


//Локальная функция в методе
//void Compare(int[] numbers1, int[] numbers2)
//{
//    int numbers1Sum = Sum(numbers1);
//    int numbers2Sum = Sum(numbers2);

//    if (numbers1Sum > numbers2Sum)
//        Console.WriteLine("сумма чисел из массива numbers1 больше");
//    else
//        Console.WriteLine("сумма чисел из массива numbers2 больше");

//    int Sum(int[] numbers)
//    {
//        int result = 0;
//        foreach (int number in numbers)
//            result += number;
//        return result;
//    }
//}

//int[] numbers1 = { 1, 2, 3 };
//int[] numbers2 = { 3, 4, 5, 6, 7 };

//Compare(numbers1, numbers2);
//--------------------------------------------------------------------------

//Типы значений и ссылочные типы
//Без ref
//Person p = new Person { name = "Tom", age = 23 };
//ChangePerson(p);

//Console.WriteLine(p.name); // Bill
//Console.WriteLine(p.age); // 45

//void ChangePerson(Person person)
//{
//    // сработает
//    person.name = "Alice";
//    // сработает
//    person = new Person { name = "Bill", age = 45 };
//}

//class Person
//{
//    public string name = "";
//    public int age;
//}
//С ref(cсылка)
//Person p = new Person { name = "Tom", age = 23 };
//ChangePerson(ref p);

//Console.WriteLine(p.name); // Bill
//Console.WriteLine(p.age); // 45

//void ChangePerson(ref Person person)
//{
//    // сработает
//    person.name = "Alice";
//    // сработает
//    person = new Person { name = "Bill", age = 45 };
//}
//class Person
//{
//    public string name = "";
//    public int age;
//}
//-------------------------------------------------------------------------
//Надо закрепить типы значений и ссылочные типы/структуры.                |
//-------------------------------------------------------------------------




//Наследование и base.
//Person person = new Person("Bob");
//person.Print();     // Bob
//Employee employee = new Employee("Tom", "Microsoft");
//employee.Print();   // Tom
//class Person
//{
//    public string Name { get; set; }
//    public Person()
//    {
//        Name = "Billy";
//        Console.WriteLine("Билли");
//    }
//    public Person(string name)
//    {
//        Name = name;
//    }
//    public void Print()
//    {
//        Console.WriteLine(Name);
//    }
//}

//class Employee : Person
//{
//    public string Company { get; set; }
//    public Employee(string name, string company) : base(name)
//    {
//        Company = company;
//    }
//}
//-----------------------------------------------------------------------------
//Делегаты
//Message message1 = Welcome.Print;
//Message message2 = new Hello().Display;

//message1(); // Welcome
//message2(); // Привет

//delegate void Message();

//class Welcome
//{
//    public static void Print()
//    {
//        Console.WriteLine("Welcome");
//    }
//}
//class Hello
//{
//    public void Display()
//    {
//        Console.WriteLine("Привет");
//    }
//}
//------------------------------------------
//Деструкторы 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Привет деструктор!");
//        Test();
//        GC.Collect();
//        Console.ReadLine();
//    }
//    private static void Test()
//    {
//        Person p = new Person();
//    }
//}
//public class Person
//{
//    public string? Name { get; set; }

//    ~Person()
//    {
//        Console.Beep();
//        Console.WriteLine("Disposed");
//    }
//}
//-------------------------------------------------------------------------------


//Делегаты....Наконец я их понял......
/*
// создаем банковский счет
Account account = new Account(200);
// Добавляем в делегат ссылку на метод PrintSimpleMessage
account.RegisterHandler(PrintSimpleMessage);
// Два раза подряд пытаемся снять деньги
account.Take(100);
account.Take(150);

void PrintSimpleMessage(string message)
{
    Console.WriteLine(message);
}

public delegate void AccountHandler(string message);
public class Account
{
    int sum;
    // Создаем переменную делегата
    AccountHandler? taken;
    public Account(int sum)
    {
        this.sum = sum;
    }
    // Регистрируем делегат
    public void RegisterHandler(AccountHandler del)
    {
        taken = del;
    }
    public void Add(int sum) => this.sum += sum;
    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            // вызываем делегат, передавая ему сообщение
            taken?.Invoke($"Со счета списано {sum} у.е.");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
}
*/
//-----------------------------------------------------------------------------------
//Классы по курсам ULearn
/*
using System.Globalization;

var city = new City();
city.Name = "Ekaterinburg";
city.Location = new GeoLocation();
city.Location.Latitude = 56.50;
city.Location.Longitude = 60.35;
Console.WriteLine("I love {0} located at ({1}, {2})", 
    city.Name, 
    city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
    city.Location.Latitude.ToString(CultureInfo.InvariantCulture));

public class City
{
    public string Name { get; set; }
    public GeoLocation Location { get; set; }
}
public class GeoLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
*/
//-----------------------------------------------------------------------

//


