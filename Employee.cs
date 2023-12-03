using System;

class Employee
{
    private string lastName;
    private string firstName;

    // Конструктор класу Employee
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Метод для розрахунку окладу та податкового збору
    public void CalculateSalary(string position, int experience)
    {
        double baseSalary = 0;

        // Визначення окладу в залежності від посади та стажу
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "designer":
                baseSalary = 55000;
                break;
            default:
                Console.WriteLine("Невірна посада");
                return;
        }

        // Додавання бонусу за стаж
        if (experience > 5)
        {
            baseSalary += 5000;
        }

        // Розрахунок податкового збору (простий приклад, податковий збір може бути більш складним)
        double tax = baseSalary * 0.15;

        // Виведення інформації про співробітника, оклад та податковий збір
        Console.WriteLine($"Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {baseSalary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}