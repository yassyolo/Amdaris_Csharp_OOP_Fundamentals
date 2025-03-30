using System.Text;

namespace Assessment4
{
    public class Person
    {
        public string Name { get; init; }
        public int Age { get; private set; }
        public string Address { get; private set; }
        public Dictionary<int, DateTime> AgeHistory { get; set; }
        public Dictionary<string, DateTime> AddressHistory { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
            AgeHistory = new() { { Age, DateTime.Now.Date } };
            AddressHistory = new() { { Address, DateTime.Now.Date } };
        }

        public virtual string GetDetails(string introduction = "Hi, ")
        {
            return $"my name is {Name} and I am {Age} years old";
        }

        public void ChangeAddress(string newAddress)
        {
            Address = newAddress;
            AddressHistory.Add(newAddress, DateTime.Now.Date);
        }

        public void CelebrateBirthday()
        {
            Age++;
            AgeHistory.Add(Age, DateTime.Now.Date);
        }

        public bool CompareAges(Person otherPerson)
        {
            return this.Age == otherPerson.Age;
        }

        public string PersonalizedReport()
        {
            var report = new StringBuilder();
            report.AppendLine($"Report for: {Name}");

            foreach (var (age, birthday) in AgeHistory)
            {
                report.AppendLine($"Turned: {age} on {birthday.ToString("d-MMM-yyyy")}");
            }

            var firstAddressKey = AddressHistory.Keys.First();

            AddressHistory.ToList().ForEach(kvp =>
            {
                if (firstAddressKey == kvp.Key)
                {
                    report.AppendLine($"Current address: {kvp.Key} changed on {kvp.Value.ToString("d-MMM-yyyy")}");
                }
                else
                {
                    report.AppendLine($"Previous address: {kvp.Key} changed on {kvp.Value.ToString("d-MMM-yyyy")}");
                }
            });

            return report.ToString();
        }
    }
}
