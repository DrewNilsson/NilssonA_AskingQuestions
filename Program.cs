// Andrew Nilsson
// 09-07-2022
// Mini Challenge #3 - Asking Questions
// This is a console project that will ask 3 questions then outputs a sentence containing the answers 
// from the questions
// Peer Review by Jovann: Runs good follows the instructions has a funny result.


Console.Clear();

bool play = true;
while (play)
{
    string? myName = "";
    string timeInput = "";

    bool validName = false;

    Console.WriteLine("What is your name?");

    while (!validName)
    {
        myName = Console.ReadLine();

        if (myName == null || myName == "")
        {
            validName = false;
            Console.WriteLine("Invalid name. Please enter a name.");
        }
        else
        {
            validName = true;
        }
    }
    Console.WriteLine("What time did you wake up? ex: 02:05 AM");

    bool validTime = false;

    while (!validTime)
    {
        timeInput = Console.ReadLine();

        if (timeInput.Length < 8)
        {
            validTime = false;
            Console.WriteLine("Invalid time format. Try again.");
        }
        else
        {

            string hour = timeInput.Substring(0, 2);
            string colon = timeInput.Substring(2, 1);
            string min = timeInput.Substring(3, 2);

            bool validHr = Int32.TryParse(hour, out int hourNum);

            bool validMin = Int32.TryParse(min, out int minNum);

            timeInput = timeInput.ToUpper();
            int validAm = timeInput.IndexOf("AM");
            int validPm = timeInput.IndexOf("PM");

            if (validHr && validMin && colon == ":" && (validAm != 0 && validPm != 0))
            {
                validTime = true;
            }
            else
            {
                Console.WriteLine("Invalid time format. Try again.");
            }

        }

    }

    Console.WriteLine($"Hello {myName}. You woke up at {timeInput}.");


    bool playInput = false;
    while (!playInput)
    {
        Console.WriteLine("Would you like to enter again? Yes or No");

        string input = Console.ReadLine().ToLower();

        if (input == "yes")
        {
            playInput = true;
        }
        else if (input == "no")
        {
            playInput = true;
            play = false;

            Console.WriteLine("Have a good day");
        }
        else
        {
            playInput = false;
        }
    }

}