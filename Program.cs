namespace GenericList
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var day = 22;
            numbers.Add(day);

            foreach (var item in numbers)
            {
                Console.WriteLine($"Number: {item}");
            }

            var persons = new List<Person>();
            var person1 = new   Person("Fred");
            persons.Add(person1);

            foreach (var person in persons)
            {
                Console.WriteLine($"Number: {person.Name}");
            }

        }
    }
}