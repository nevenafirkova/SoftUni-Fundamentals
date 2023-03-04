﻿//INPUT
string info = string.Empty;

//ACTION
Dictionary<string, List<string>> employees = new Dictionary<string, List<string>>();

while ((info = Console.ReadLine()) != "End")
{
    string[] infoArray = info.Split(" -> ");
    string company = infoArray[0];
    string id = infoArray[1];

    if (!employees.ContainsKey(company))
    {
        List<string> idsList = new List<string>();
        if (!idsList.Contains(id))
        {
            idsList.Add(id);
            employees.Add(company, idsList);
        }
    }
    else
    {
        List<string> idsList = new List<string>();
        employees[company].Add(id);
    }
}

//OUTPUT
foreach (var employee in employees)
{
    Console.WriteLine(employee.Key);

    for (int i = 0; i < employee.Value.Count; i++)
    {
        Console.WriteLine($"-- {employee.Value[i]}");
    }
}