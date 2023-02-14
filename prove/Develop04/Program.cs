class Program
{
    static void Main(string[] args)
    {

        string choice = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine($"****** Welcome, User ********");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();
            
            if(choice == "1"){
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.RunActivity();
                breathingActivity.DisplayEndingMessage();
            }
            else if(choice == "2"){
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.DisplayStartingMessage();
                reflectionActivity.RunActivity();
                reflectionActivity.DisplayEndingMessage();  

            }
            else if(choice == "3"){
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.RunActivity();
                listingActivity.DisplayEndingMessage();  
            }
            else{
                break;
            }            
        }while(choice != "4");
    }
}