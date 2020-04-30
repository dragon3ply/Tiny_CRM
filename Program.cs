using System;
using Tiny_CRM;

namespace Tiny_Crm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var vdrakos = new Customer("sasdds");
            }
            catch (Exception ex)
            {
                Console.WriteLine("please enter agian");
            }
            //vdrakos.Vatnum = "123456789";
            // vdrakos.IsValidAfm();
            //vdrakos.Email = "drakosaris@hotmail.com";

        }

        /*public static bool IsValidAfm(string afm)
        {
            if (string.IsNullOrWhiteSpace(afm))
            {
                return false;
            }
            afm = afm.Trim();

            if (afm.Length != 9)
            {
                return false;
            }
            if (!int.TryParse(afm, out int number))
            {
                return false;
            }
            // return afm.Length == 9 && int.TryParse(afm, out int num);

            return true;
        }*/ 

            //dssfgsdfggsdf
            //sdaf
            



        public static bool IsAdult(int age)
        {

            if (age >= 18 && age <= 100)
            {
                return true;
            }
            return false;
        }


        bool IsValidEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                email = email.Trim();
                if (email.Contains("@") &&
                    (email.EndsWith(".com") || email.EndsWith(".gr")))
                {
                    return true;
                }
            }
            return false;

        }

    }
}