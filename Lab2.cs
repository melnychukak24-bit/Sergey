using System;

class Abonent
{
    
    private string phoneNumber;

    
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set
        {
           
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("Номер телефону повинен містити тільки цифри!");
                }
            }
            phoneNumber = value;
        }
    }

    
    public int SumOfDigits()
    {
        int sum = 0;
        foreach (char c in phoneNumber)
        {
            sum += c - '0'; 
        }
        return sum;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Abonent abonent = new Abonent();

            Console.Write("Введіть номер телефону: ");
            abonent.PhoneNumber = Console.ReadLine();

            Console.WriteLine($"Сума цифр номера: {abonent.SumOfDigits()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
