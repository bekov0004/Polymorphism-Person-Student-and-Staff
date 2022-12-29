namespace Home_Work.Services;
    public class Student : Person
    {
    private string _program;
    private int _year;
    private double _fee;
    public Student(string name, string address, string program, int year,  double fee)
        :base(name,address)
    {
        _program = program;
        _year = year;
        _fee = fee;
    }
    public string GetProgram()
    {
        return _program;
    }
    public void SetProgram(string program)
    {
        _program = program;
    }
    public int GetYear()
    {
        return _year;
    }
    public void SetYear(int year)
    {
        _year = year;
    }

    public double GetFee()
    {
        return _fee;
    }
    public void SetFee(double fee)
    {
        _fee = fee;
    }
    public override string ToString()
    {
        return $"Student {base.ToString()}, Program: {_program}, Year: {_year}, Fee: {_fee}";
    }
}

