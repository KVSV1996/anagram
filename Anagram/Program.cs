namespace Program
{
    class Anagram
    {
        static void Main()
        {            
            Console.WriteLine("This program reverses your text. \nTry to enter:");
            string consoleText = Console.ReadLine();
            Console.WriteLine(StringReverseService.Reverse(consoleText));
            Console.ReadLine(); 
        }        
    }    
}