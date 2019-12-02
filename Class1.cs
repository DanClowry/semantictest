using System;

namespace semantictest
{
    public class Class1
    {
        public string Hello(string name)
        {
            return $"Hello {name}";
        }

        public string Bye()
        {
            return "Goodbye";
        }

        public DateTime Time()
        {
            return DateTime.Now;
        }
    }
}
