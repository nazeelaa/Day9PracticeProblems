using System;

namespace AddressBook
{
    class Program
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State{ get; set; }
        public int Zipcode { get; set; }
        public Double Phonenumber { get; set; }
        public string Emailid{ get; set; }

        public void displayContact()
        {
            Console.WriteLine("FirstName:" + this.FristName +
                              "LastName:" + this.LastName +
                              "Address:" + this.Address + 
                              "City:" + this.City +
                              "State:" + this.State + 
                              "zipcode" + this.Zipcode + 
                              "PhoneNumber:" + this.Phonenumber +
                              "Emailid:" + this.Emailid);
        }

        static void Main(string[] args)
        {
            Console.Write("enter first name,last name, address, city,state,zipcode,phonenumber,emialid\n");

            Program objProgram = new Program()
            {
                FristName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zipcode = Convert.ToInt32(Console.ReadLine()),
                Phonenumber = Convert.ToInt32(Console.ReadLine()),
                Emailid = Console.ReadLine()
            };
        objProgram.displayContact();
            Console.ReadLine();
        }
    }
}
