using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INECASSIGNMENT1
{
    internal class Inec_assignment2
    {
        public void Inec()
        {
            SortedSet<string> sortedset_inec = new SortedSet<string>();
            sortedset_inec.Add("ayo");
            sortedset_inec.Add("kingsley");
            sortedset_inec.Add("ibrahim");
            sortedset_inec.Add("odunayo");
            sortedset_inec.Add("ike");
            sortedset_inec.Add("hassan");
            sortedset_inec.Add("tobi");
            sortedset_inec.Add("pius");
            sortedset_inec.Add("mariam");

            Console.WriteLine("Enter your name");
           string userName= Console.ReadLine();
            userName = userName.ToLower(); //change every entry to lowercase
            if (sortedset_inec.Contains(userName))
            {
              Console.WriteLine("Access Denied");
            }
            else
            {
                sortedset_inec.Add(userName);
                Console.WriteLine("User added successfully");
            }

        }
    }
}
