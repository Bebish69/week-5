

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("The teacher teaches using English.");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Salary details: this teacher receives a monthly payment.");
    }
}
