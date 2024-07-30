using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Admin admin = new Admin();
            
            

            List<User> users = new List<User>
            {
    
            };

            while (true)
            {
                Console.WriteLine("1. login");
                Console.WriteLine("enter your choice ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter your ID to log in");
                        int enteredId = int.Parse(Console.ReadLine());
                        User loggedInUser = users.FirstOrDefault(u => u.ID == enteredId);

                        if (loggedInUser != null)
                        {
                            Console.WriteLine($"{loggedInUser.UserName} logged in!");

                            if (loggedInUser.UserType == UserType.Admin)
                            {
                                Console.WriteLine("choose you option as admin:");
                                Console.WriteLine("1. add user");
                                Console.WriteLine("2. See all users");
                                Console.WriteLine("3. update user");
                                Console.WriteLine("4. delete user");
                                Console.WriteLine("5. See transactions ");

                                int loggedIn_choice = int.Parse(Console.ReadLine());

                                if (loggedIn_choice == 1)
                                {
                                    admin.AddUser(  );
                                }

                                if (loggedIn_choice == 2)
                                {
                                    admin.SeeAllUsers();
                                }

                                if (loggedIn_choice == 3)
                                {
                                    admin.UpdateUser();
                                }


                                if (loggedIn_choice == 3)
                                {
                                    admin.DeleteUser();
                                }


                                if (loggedIn_choice == 3)
                                {
                                    admin.DeleteUser();
                                }







                            }
                            else
                            {
                                Console.WriteLine("choose you option as user:");
                                Console.WriteLine("1. Transfer money");
                                Console.WriteLine("2. See my money");

                                int user_choice = int.Parse(Console.ReadLine());

                                switch (user_choice)
                                {
                                    case 1:
                                        Console.WriteLine("Enter recipient ID:");
                                        int recipientId = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter amount:");
                                        int amount = int.Parse(Console.ReadLine());
                                        loggedInUser.TransferMoney(recipientId, amount);
                                        break;
                                    case 2:
                                        loggedInUser.SeeMymoney();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }

}