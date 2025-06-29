using System;
using System.Diagnostics;

class Program
{
    static Employee?[] employees = new Employee?[100];
    static int count = 0;

    static void AddEmployee(Employee emp)
    {
        var stopwatch = Stopwatch.StartNew();

        if (count >= employees.Length)
        {
            stopwatch.Stop();
            Logger.Log($"❌ Employee array is full. [Time Complexity: O(1), Duration: {stopwatch.ElapsedMilliseconds} ms]");
            return;
        }

        employees[count++] = emp;

        stopwatch.Stop();
        Logger.Log($"✅ Employee added: {emp.EmployeeId}, {emp.Name}, {emp.Position}, ₹{emp.Salary} [Time Complexity: O(1), Duration: {stopwatch.ElapsedMilliseconds} ms]");
    }

    static void SearchEmployee(int id)
    {
        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
        {
            var emp = employees[i];
            if (emp != null && emp.EmployeeId == id)
            {
                stopwatch.Stop();
                Logger.Log($"🔍 Found Employee ID {id}: {emp.Name}, {emp.Position}, ₹{emp.Salary} [Time Complexity: O(n), Duration: {stopwatch.ElapsedMilliseconds} ms]");
                return;
            }
        }

        stopwatch.Stop();
        Logger.Log($"❌ Employee ID {id} not found. [Time Complexity: O(n), Duration: {stopwatch.ElapsedMilliseconds} ms]");
    }

    static void TraverseEmployees()
    {
        var stopwatch = Stopwatch.StartNew();

        if (count == 0)
        {
            stopwatch.Stop();
            Logger.Log($"ℹ️ No employees to display. [Time Complexity: O(1), Duration: {stopwatch.ElapsedMilliseconds} ms]");
            return;
        }

        Logger.Log($"📋 Traversing Employee List: [Time Complexity: O(n)]");
        for (int i = 0; i < count; i++)
        {
            var emp = employees[i];
            if (emp != null)
            {
                Logger.Log($"ID: {emp.EmployeeId}, Name: {emp.Name}, Position: {emp.Position}, Salary: ₹{emp.Salary}");
            }
        }

        stopwatch.Stop();
        Logger.Log($"✅ Traversal Complete. Duration: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void DeleteEmployee(int id)
    {
        var stopwatch = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
        {
            var emp = employees[i];
            if (emp != null && emp.EmployeeId == id)
            {
                string deletedInfo = $"ID: {emp.EmployeeId}, Name: {emp.Name}";
                for (int j = i; j < count - 1; j++)
                {
                    employees[j] = employees[j + 1];
                }
                employees[--count] = null;

                stopwatch.Stop();
                Logger.Log($"🗑 Deleted Employee → {deletedInfo} [Time Complexity: O(n), Duration: {stopwatch.ElapsedMilliseconds} ms]");
                return;
            }
        }

        stopwatch.Stop();
        Logger.Log($"❌ Employee ID {id} not found for deletion. [Time Complexity: O(n), Duration: {stopwatch.ElapsedMilliseconds} ms]");
    }

    static void Main()
    {
        AddEmployee(new Employee(1, "Alekya", "Developer", 65000));
        AddEmployee(new Employee(2, "Ravi", "Manager", 85000));
        AddEmployee(new Employee(3, "Sara", "Analyst", 55000));

        TraverseEmployees();
        Console.WriteLine();

        SearchEmployee(2);
        Console.WriteLine();

        DeleteEmployee(2);
        TraverseEmployees();
    }
}
