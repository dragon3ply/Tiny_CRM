using System;
using System.Collections.Generic;
using System.Text;

namespace Tiny_CRM
{
    public class Customer
    {
        public DateTime Created { get; set; }
        public string Email { get; set; }
        public string Vatnum { get; set; }
        public string Phone { get; set; }
        public decimal Totalgross { get; private set; }
        public bool IsActive { get; set; }

        public Customer(string vatnum)
        {
            if (!IsValidAfm(vatnum))
            {
                throw new Exception("Invalid Vat");
            }
            Vatnum = vatnum;
            Created = DateTime.Now;


        }

        public bool IsValidAfm(string vatnum)
        {
            if (string.IsNullOrWhiteSpace(vatnum))
            {
                return false;
            }
            Vatnum = Vatnum.Trim();

            if (vatnum.Length != 9)
            {
                return false;
            }
            if (!int.TryParse(Vatnum, out int number))
            {
                return false;
            }
            // return afm.Length == 9 && int.TryParse(afm, out int num);

            return true;
        }


        bool IsValidEmail()
        {
            if (!string.IsNullOrWhiteSpace(Email))
            {
                Email = Email.Trim();
                if (Email.Contains("@") &&
                    (Email.EndsWith(".com") || Email.EndsWith(".gr")))
                {
                    return true;
                }
            }
            return false;


            /* public bool IshighValuedCustomer()
            {
                return Totalgross > 10000M;
            }

            public void Setphone(string phone)
            {
                Phone = phone;
            }*/

        }
    }
}
