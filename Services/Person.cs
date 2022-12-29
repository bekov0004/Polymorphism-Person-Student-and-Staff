namespace Home_Work.Services;
    public abstract class Person
    {
    private string _name;
    private string _address;
    public Person(string name, string address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        _address = address;
    }
    public override string ToString()
    {
        return $"Person: Name: {_name}, Address: {_address }";
    }

}

