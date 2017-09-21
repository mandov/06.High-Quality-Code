namespace GenerateHuman
{
    using GenerateHuman.Enums;

    public class HumanGenerator
    {
        public void Generator(int years)
        {
            Human human = new Human();
            human.Age = years;
            if (years % 2 == 0)
            {
                human.Name = "Батката";
                human.Gender = Gender.Male;
            }
            else
            {
                human.Name = "Мацето";
                human.Gender = Gender.Female;
            }
        }
    }
}