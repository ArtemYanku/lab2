using System;

// Клас Address
class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

// Клас Converter
class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double amount)
    {
        return amount / usd;
    }

    public double ConvertToEUR(double amount)
    {
        return amount / eur;
    }

    public double ConvertToPLN(double amount)
    {
        return amount / pln;
    }

    public double ConvertFromUSD(double amount)
    {
        return amount * usd;
    }

    public double ConvertFromEUR(double amount)
    {
        return amount * eur;
    }

    public double ConvertFromPLN(double amount)
    {
        return amount * pln;
    }
}

// Клас Employee
class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0.0;

        // Розрахунок окладу в залежності від посади та стажу
        switch (position)
        {
            case "Менеджер":
                baseSalary = 30000;
                break;
            case "Розробник":
                baseSalary = 40000;
                break;
            case "Тестувальник":
                baseSalary = 25000;
                break;
                // Додайте інші можливі посади та їх оклади
        }

        double tax = baseSalary * 0.15; // Податковий збір 15%

        Console.WriteLine("Прізвище: " + lastName);
        Console.WriteLine("Ім'я: " + firstName);
        Console.WriteLine("Посада: " + position);
        Console.WriteLine("Оклад: " + baseSalary);
        Console.WriteLine("Податковий збір: " + tax);
    }
}

// Клас User
class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Логін: " + login);
        Console.WriteLine("Ім'я: " + firstName);
        Console.WriteLine("Прізвище: " + lastName);
        Console.WriteLine("Вік: " + age);
        Console.WriteLine("Дата заповнення анкети: " + registrationDate);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад створення об'єкту класу Address
        Address address = new Address();
        address.Index = "02100";
        address.Country = "Україна";
        address.City = "Київ";
        address.Street = "Ярослава Гашека";
        address.House = "15";
        address.Apartment = "12";

        Console.WriteLine("Поштова адреса:");
        Console.WriteLine("Індекс: " + address.Index);
        Console.WriteLine("Країна: " + address.Country);
        Console.WriteLine("Місто: " + address.City);
        Console.WriteLine("Вулиця: " + address.Street);
        Console.WriteLine("Будинок: " + address.House);
        Console.WriteLine("Квартира: " + address.Apartment);

        // Приклад створення об'єкту класу Converter
        Converter converter = new Converter(25.0, 41.0, 11.0);

        double amountInUAH = 1000.0;
        double amountInUSD = converter.ConvertToUSD(amountInUAH);
        double amountInEUR = converter.ConvertToEUR(amountInUAH);
        double amountInPLN = converter.ConvertToPLN(amountInUAH);

        Console.WriteLine("1000 гривень дорівнюють:");
        Console.WriteLine(amountInUSD + " доларів");
        Console.WriteLine(amountInEUR + " євро");
        Console.WriteLine(amountInPLN + " злотих");

        // Приклад створення об'єкту класу Employee
        Employee employee = new Employee("Янку", "Артем");
        employee.CalculateSalaryAndTax("Менеджер", 5);

        // Приклад створення об'єкту класу User
        User user = new User("user854", "Артем", "Янку", 20);
        user.DisplayUserInfo();

        Console.ReadLine();
    }
}

