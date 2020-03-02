namespace qwe.Classes
{
    public class Person
    {
        private string _fname;
        private string _lname;
        private Address _address;

        public string FirstName { get => _fname; set => _fname = value; }
        public string LastName { get => _lname; set => _lname = value; }
        public Address Address { get => _address; set => _address = value; }
        
        /*Initialize Person attributes */
        public Person(string fname, string lname, Address addr)
        {

        }
        
        /* Implement a Person ToString() */
    }
}