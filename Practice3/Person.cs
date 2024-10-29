public class Person : IComparable<Person>, ICloneable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person other)
    {
        return Age.CompareTo(other.Age);
    }

    public object Clone()
    {
        return new Person(Name, Age);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

public class PersonNameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }
}