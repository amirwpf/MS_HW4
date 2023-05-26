using HW4.DB;
using HW4.Repository;

UserDataBase userdb = new UserDataBase(); 
userdb.LoadUsersDB();

UserRepository userRepository = new UserRepository();



while(true)
{
    Console.WriteLine("###################");
    Console.WriteLine("Pls choose your function");
    Console.WriteLine("1- create");
    Console.WriteLine("2- read all");
    Console.WriteLine("3- update");
    Console.WriteLine("4- delete");
    Console.WriteLine("###################");
    int choose= int.Parse(Console.ReadLine());

    switch(choose)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("###################");
            Console.WriteLine("pls enter name");
            var namee= Console.ReadLine();
            Console.WriteLine("pls enter phone number");
            var phone = Console.ReadLine();
            Console.WriteLine("pls enter birth year");
            var year = int.Parse(Console.ReadLine());

            userRepository.Create(namee, phone, new DateTime(year, 01, 01));

            break;

        case 2:
            Console.Clear();
            Console.WriteLine("###################");
            foreach (var item in userRepository.GetAll())
            {
                Console.WriteLine(item.Phone);
            }
            break;

        case 3:

            break;

        case 4:
            Console.Clear();
            Console.WriteLine("###################");
            Console.WriteLine("choose name for delete");
            foreach (var item in userRepository.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            var namee_ = Console.ReadLine();
            userRepository.Delete(namee_);
            break;
    }
}