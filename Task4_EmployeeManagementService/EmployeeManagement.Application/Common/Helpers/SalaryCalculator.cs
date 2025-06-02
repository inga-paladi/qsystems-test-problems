namespace EmployeeManagement.Application.Common.Helpers;

public static class SalaryCalculator
{
    public static decimal Calculate(string position)
    {
        return position.ToLower() switch
        {
            "manager" => 15000m,
            "developer" => 12000m,
            "intern" => 5000m,
            _ => 10000m
        };
    }
}
