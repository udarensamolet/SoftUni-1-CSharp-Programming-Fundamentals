namespace OldestFamilyMember
{
    class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public void AddMember(Person member)
        {
            if (!People.Contains(member))
            {
                People.Add(member);
            }
        }

        public List<Person> People { get; set; }

        public Person GetOldestMember()
        {
            int oldestAge = int.MinValue;
            foreach (var person in People)
            {
                if (person.Age > oldestAge)
                {
                    oldestAge = person.Age;
                }
            }
            Person oldestPerson = this.People.FirstOrDefault(x => x.Age == oldestAge);
            return oldestPerson;
        }
    }
}