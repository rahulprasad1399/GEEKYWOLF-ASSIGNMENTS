//public class emp
//{
//    public string n; public int a;
//    public double s;
//    public void calc()
//    {
//        double x = s * 0.1;
//        double y = s + x;
//    }
//}

public class Employee
{
    public string FullName {  get; set; } 
    public int Age { get; set; }
    public double BaseSalary { get; set; }

    public void CalculateSalaryWithBonus()
    {
        double bonus = BaseSalary * 0.1;
        double TotalSalary = BaseSalary + bonus;    
    }

}
