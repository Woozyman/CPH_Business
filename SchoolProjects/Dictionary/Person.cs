namespace Dictionary
{
    public class Person
    {
        public string Name { get; set; }
        public int PersonId { get; set; }
        private static int id = 1;

        public Person()
        {
            PersonId = id++;
        }
        public Person(string name)
        {
            Name = name;
            PersonId = id++;
        }


    }
}
