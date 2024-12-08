namespace Midterm

{
   internal class MyClass
    {
        static void Main()
        {
         Welcome welcome = new Welcome();
         welcome.WelcomeMessage();
         
         Questions questions = new Questions();
         questions._Questions(welcome.name);
         

        }
    }
}

 