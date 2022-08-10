namespace INECASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Inec_assignment2 inec_assignment = new Inec_assignment2();

            inec_assignment.Inec();
            Dictionary<int, string> InecRegistration = new Dictionary<int, string>()
        {
            {1, "Adeola Aderenle" },
            {2, "Temidayo Okeowo" },
            {3, "Odunayo Abegunde"},
            {4, "Ikechukwu Bright"},
            {5,"Matthew Timadi" },
            {6, "Temidayo Okeowo" },
            {7,"Florence Ikpamo" },
            {8,"Bola Ige"},
            {9, "Mustapha Idris"  },
            {10, "Odunayo Abegunde" },

        };
            Console.WriteLine("Voters Registration ");

            foreach (KeyValuePair<int, string> dups in InecRegistration) //Go through the array and check for duplicate 
            {
                Console.WriteLine(dups.Key + "  " + dups.Value);
            }
            var duplicateValues = InecRegistration.GroupBy(x => x.Value).Where(x => x.Count() > 1); //Group the duplicate names

            Console.WriteLine("The Duplicates are: ");

            foreach (var name in duplicateValues)   //Prints out the duplicate names
            {
                Console.WriteLine(name.Key);
            }




            


        }
    }
}