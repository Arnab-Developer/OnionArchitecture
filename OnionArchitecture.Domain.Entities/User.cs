namespace OnionArchitecture.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public int Age { get; set; }
        public bool? IsAdult { get; set; }

        public void DetermineAdult()
        {
            if (Age >= 18) IsAdult = true;
            else IsAdult = false;
        }
    }
}
