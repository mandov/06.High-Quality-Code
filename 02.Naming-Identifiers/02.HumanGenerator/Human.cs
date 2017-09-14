using GenerateHuman.Enums;

public class Human
{
    private Gender gender;
    private string name;
    private int age;

    public Gender Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            this.gender = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
    }
}