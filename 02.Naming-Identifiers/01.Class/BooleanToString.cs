namespace BooleanToStringConverter
{
    using System;

    public class BooleanToString
    {       
        public void Converter(bool value)
        {
            string valueLikeString = value.ToString();
            Console.WriteLine(valueLikeString);
        }    
    }
}