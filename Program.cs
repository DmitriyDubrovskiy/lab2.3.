class Program
{
    static void Main()
    {
        // Створення екземпляру класу Employee
        Employee employee = new Employee("Ivanov", "Ivan");

        // Розрахунок та виведення інформації про співробітника, оклад та податковий збір
        employee.CalculateSalary("developer", 7);
    }
}
