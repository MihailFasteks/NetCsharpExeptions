using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpExeptions
{
     class CreditCard
    {
        public string Number {  get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public string CVC {  get; set; }
        public string finishDate {  get; set; }

       public CreditCard()
        {
            Number = "";
            Name = "";
            LastName = ""; 
            SureName = "";
            CVC = "";
            finishDate = "";
        }
        public CreditCard(string n):this(n, "", "", "", "", "") { }
        public CreditCard(string n, string nm) : this(n, nm, "", "", "", "") { }
        public CreditCard(string n, string nm, string ln) : this(n, nm, ln, "", "", "") { }
        public CreditCard(string n, string nm, string ln, string sn) : this(n, nm, ln, sn, "", "") { }
        public CreditCard(string n, string nm, string ln, string sn, string cvc) : this(n, nm, ln, sn, cvc, "") { }
        public CreditCard(string n, string nm, string ln, string sn, string cvc, string fd)
        {
            try
            {
                Number = n;
                Name = nm;
                LastName = ln;
                SureName = sn;
                CVC = cvc;
                finishDate = fd;
                //throw new Exception("Wrong value");

                if (Number.Length != 16)
                {
                    throw new Exception("Wrong length of card number");
                }
                if (Number.All(char.IsDigit) == false)
                {
                    throw new Exception("Wrong value of card number");
                }
                if (Name.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Name");
                }
                if (LastName.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Last Name");
                }
                if (SureName.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Sure Name");
                }
                if (CVC.All(char.IsDigit) == false)
                {
                    throw new Exception("Wrong value of CVC");
                }
                if (CVC.Length != 3)
                {
                    throw new Exception("Wrong length of CVC");
                }
                if (finishDate.Length != 5)
                {
                    throw new Exception("Wrong length of CVC");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        

        }
        public void Input()
        {
            try
            {
                Console.WriteLine("Input your card number");
                Number = Console.ReadLine();
                Console.WriteLine("Input your name");
                Name = Console.ReadLine();
                Console.WriteLine("Input your last name");
                LastName = Console.ReadLine();
                Console.WriteLine("Input your sure name");
                SureName = Console.ReadLine();
                Console.WriteLine("Input your CVC-code");
                CVC = Console.ReadLine();
                Console.WriteLine("Input your card finish date in format MM.YY");
                finishDate = Console.ReadLine();

                if (Number.Length != 16)
                {
                    throw new Exception("Wrong length of card number");
                }
                if (Number.All(char.IsDigit) == false)
                {
                    throw new Exception("Wrong value of card number");
                }
                if (Name.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Name");
                }
                if (LastName.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Last Name");
                }
                if (SureName.All(char.IsLetter) == false)
                {
                    throw new Exception("Wrong value of Sure Name");
                }
                if (CVC.All(char.IsDigit) == false)
                {
                    throw new Exception("Wrong value of CVC");
                }
                if (CVC.Length != 3)
                {
                    throw new Exception("Wrong length of CVC");
                }
                if (finishDate.Length != 5)
                {
                    throw new Exception("Wrong length of CVC");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}
