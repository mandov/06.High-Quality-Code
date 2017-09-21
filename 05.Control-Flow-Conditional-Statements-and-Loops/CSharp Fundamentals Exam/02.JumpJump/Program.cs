namespace JumpJump
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string instructions = Console.ReadLine();
            int position = 0;

            for (int index = 0; index <= instructions.Length - 1;)
            {
                position = instructions[index] - 48;

                if (position % 2 != 0)
                {
                    index = index - position;
                    if (index < 0 || index > instructions.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", index);
                        break;
                    }
                }

                if (position == 0)
                {
                    Console.WriteLine("Too drunk to go on after {0}!", index);
                    break;
                }

                if (position == 46)
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", index);
                    break;
                }

                if (position % 2 == 0)
                {
                    index = index + position;
                    if (index > instructions.Length)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", index);
                    }
                }
            }
        }
    }
}
