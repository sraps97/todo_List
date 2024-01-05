var userDescription = new List<string>();
Console.WriteLine("Hello Welcome to the Todo List");
bool isUserChoice = false;

while (!isUserChoice)
{
    Console.WriteLine("What do yoou want to do ?");
    Console.WriteLine("[S]ee all the Todos");
    Console.WriteLine("[A]dd a Todos");
    Console.WriteLine("[R]emove a Todo");
    Console.WriteLine("[E]xit");

    string input = Console.ReadLine();

    switch (input)
    {
        case "e":
        case "E":
            isUserChoice = true;
            break;
        case "s":
        case "S":
            Console.WriteLine("See the Todos");
            break;
        case "a":
        case "A":
            Add();
            break;
        case "r":
        case "R":
            Console.WriteLine("Remove a Todo");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;


    }
}

void Add()
{

    bool isDescription = false;

    while (!isDescription)
    {
        Console.WriteLine("Enter the Todo Descriiption");
        string description = Console.ReadLine();
        if (description == "")
        {
            Console.WriteLine("The description cannot be empty");
        }
        else if (userDescription.Contains(description))
        {
            Console.WriteLine("The decription must be unique");
        }
        else
        {
            userDescription.Add(description);
            Console.WriteLine("Todo successfully added " + description);
            isDescription = true;
        }

    }


}
//void Remove()
//{ 
//}