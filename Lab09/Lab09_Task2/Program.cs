namespace Lab09_Task2
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Console.Write("Making a Staff class\n");
            Staff dum = new Staff();
            Console.WriteLine(dum.whoAmI());
            Console.Write(dum.getjobStatus()+"\n");
            //private attribute which didn't get inherited
            Console.Write("Making a Teacher class\n");
            Teacher dumm = new Teacher();
            Console.WriteLine(dumm.whoAmI());
            //example of polymorphism using virtual and override
            //Console.WriteLine(" " + dumm.Name);
            //protected attribute got inherited but can't be accessed from a different class can't be accessed from a different class in the same namespace
            Console.WriteLine(" "+dumm.Name);
            //attribute got inherited from staff to teacher
            Console.WriteLine(" " + dumm.security);
            //internal attribute did get inherited and can be used from a different class
            Console.Write(" " + dumm.Respect + "\n");
            // internal protected attribute got inherited and can be accessed from a different class in the same namespace

            Console.Write("Making an Officer class\n");
            Officer dummy = new Officer();
            Console.WriteLine(dummy.whoAmI());
            Console.Write("Making a regular typist class\n");
            Regular dumdum = new Regular();
            Console.WriteLine(dumdum.whoAmI());
            Console.Write("Making a casual typist class\n");
            Casual dumdumdum = new Casual();
            Console.WriteLine(dumdumdum.whoAmI());
            //example of polymorphism where the overriden function is overridable by default

        }
    }
}
