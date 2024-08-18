// See https://aka.ms/new-console-template for more information

using ImdbList;

List<Film> filmList = new List<Film>();

while (true)
{
    Film film = new Film();
    Console.Write("Name: ");
    film.Name = Console.ReadLine();
    Console.Write("Rating: ");
    film.Rating = Convert.ToDouble(Console.ReadLine());

ask:    Console.Write("Wanna add another film ? (y/n): ");
    string answer = Console.ReadLine();

    if (answer == "y")
    {
        
    }
    else if (answer == "n")
    {
        break;
    }
    else
    {
        Console.WriteLine("Wrong input!!");
        goto ask;
    }
    
    filmList.Add(film);
}




void printList(List<Film> list)
{
    Console.WriteLine("---------All Films List---------");
    foreach (var i in list)
    {
        Console.WriteLine(i);
    }
}

void betweenFourNine(List<Film> list)
{
    Console.WriteLine("-----------Films Between 4-9 Rating-------------");
    foreach (var i in list)
    {
        if (i.Rating >= 4 && i.Rating <= 9)
        {
            Console.WriteLine(i);
        }
    }
}

void initialA(List<Film> list)
{
    foreach (var i in list)
    {
        Console.WriteLine("---------Films Starting with A----------");
        char[] charArray = {  };
        charArray = i.Name.ToCharArray();
        if (charArray[0] == 'A' || charArray[0] == 'a')
        {
            Console.WriteLine(i);
        }
    }
}

question: Console.WriteLine(@"1) List All Films: 
2) List Films Between 4-9 Rating: 
3) Films Starting with A: ");

string answer2 = Console.ReadLine();

switch (answer2)
{
    case  "1":
        printList(filmList);
        break;
    case "2":
        betweenFourNine(filmList);
        break;
    case "3":
        initialA(filmList);
        break;
    default:
        Console.WriteLine("Wrong input!!");
        goto question;
}
