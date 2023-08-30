using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;// saving with json
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Gym
{
    [Serializable]//saving 
    class Service
    {
        public Service()
        {
            readClient();
            readCoach();
        }
        int coachI = 0;
        int clientI = 0;
        Coach[] ArrCoach = new Coach[100];
        Client[] ArrClient = new Client[100];
        private void addClienttoarr()// method for + client to arr
        {
            ArrClient[clientI] = new Client();
            ArrClient[clientI].NewClient();
            clientI++;

        }
        private void addCoachtoarr()// method for + coach to arr
        {
            ArrCoach[coachI] = new Coach();
            ArrCoach[coachI].NewCoach();
            coachI++;

        }
        public void Runmenu1()
        {
            while (true)
            {
                PrintMenu();
                char choice = Console.ReadLine()[0];

                if (choice == '1')// choice 1 is for new client menu 
                {
                    addClienttoarr();
                }
                else if (choice == '2')// choice 2 is for new coach 
                {
                    addCoachtoarr();
                }
                else if (choice == '3')// to show the client  
                {
                    printNameClient(/*ArrClient*/);
                }
                else if (choice == '4')// to show the coach details
                {
                    printNameCoach(/*ArrCoach*/);
                }
                else if (choice == '5') // for client save 
                {
                    SaveClient();
                }
                else if (choice == '6')// for coach save
                {
                    SaveCoach();
                }
                else if (choice == '7')
                {
                    while (choice != 'm')
                    {
                        Console.Write("[1] for client, [2] for coach, [m] return to menu\n> ");
                        char userChoice = Console.ReadLine()[0];
                        if (userChoice == '1')
                        {
                            Console.Write("Enter card token: ");
                            string cardToken = Console.ReadLine();
                            Client foundClient = FindClientByCardToken(cardToken);
                            if (foundClient != null)
                            {
                                Console.WriteLine("Client: " + foundClient.GetFullName() + "\nHave a good train you lazy bum!");
                            }
                            else
                            {
                                Console.WriteLine("Client not found try again");
                                cardToken = Console.ReadLine();
                            }
                        }
                        else if (userChoice == '2')
                        {
                            Console.WriteLine("enter your empolyee ID : ");
                            string employeeID = Console.ReadLine();
                            Coach foundCoach = FindCoachByEmpoleeID(employeeID);
                            if (foundCoach == null)
                            {
                                Console.WriteLine("Coach not found try again");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Coach found : " + foundCoach.GetFullName() + "\n login success take care  ");
                            }

                        }
                        else if (userChoice == 'm')
                            break;

                        else
                        {
                            Console.WriteLine("worng choice press 1 or 2 or m ");
                        }

                    }
                }
                else if (choice == '8')// update client or coach 
                {
                    Runmenu2();
                }
            }
        }
      
        public void updateCoach()
        {
            try
            {
                // read the coach from my array 
                Coach[] arrCoach = JsonConvert.DeserializeObject<Coach[]>(File.ReadAllText("saveCoach.json"));
                //take the empolee number
                Console.WriteLine("enter your empolyee ID : ");
                string employeeID = Console.ReadLine();
                // search the empolee number 
                for (int i = 0; i < arrCoach.Length; i++)
                {
                    if (arrCoach[i] != null && arrCoach[i].EmployeeID == employeeID)
                    {
                        Console.WriteLine("log in success");
                        Console.WriteLine("Please enter your updated first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Please enter your updated last name:");
                        string lastName = Console.ReadLine();

                        arrCoach[i].Firstname = firstName;//update the array  
                        arrCoach[i].LastName = lastName;
                        //save it 
                        string output = JsonConvert.SerializeObject(arrCoach);
                        File.WriteAllText("saveCoach.json", output);

                        Console.WriteLine("Your name has been updated ");
                        return;

                    }
                }
                //if the card token is worng 
                Console.WriteLine("Invalid emploee id . Please try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while updating your name.");
            }
        }
        public void UpdateClient()
        {
            try
            {// read the client  from my array 
                Client[] arrClient = JsonConvert.DeserializeObject<Client[]>(File.ReadAllText("saveClient.json"));
                // take the card token 
                Console.WriteLine("Please enter your card token:");
                string cardToken = Console.ReadLine();
                // search by card token 
                for (int i = 0; i < arrClient.Length; i++)
                {
                    if (arrClient[i] != null && arrClient[i].CardToken == cardToken)
                    {//take the input 
                        Console.WriteLine("log in success");
                        Console.WriteLine("Please enter your updated first name:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Please enter your updated last name:");
                        string lastName = Console.ReadLine();


                        arrClient[i].Firstname = firstName;//update the array 
                        arrClient[i].LastName = lastName;

                        //save again 
                        string output = JsonConvert.SerializeObject(arrClient);
                        File.WriteAllText("saveClient.json", output);

                        Console.WriteLine("Your name has been updated successfully!");
                        return;
                    }
                }
                //if the card token is worng 
                Console.WriteLine("Invalid card token. Please try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred while updating your name.");
            }
        }
		private void Runmenu2()
		{
			PrintMenu2();
			char userChoice2 = Console.ReadLine()[0];

			while (true)
			{
				if (userChoice2 == '1') // for edit details client
				{
					Client updatedClient = new Client();
					UpdateClient();
				}
				else if (userChoice2 == '2') // for edit details coach
				{
					Coach updatedcoach = new Coach();
					updateCoach();
				}
				else if (userChoice2 == '3') // for delete client
				{
					// Implement delete logic here
					// You can break the loop or add additional logic as needed
					break;
				}
				else if (userChoice2 == 'n') // to return to the main menu
				{
					return; 
				}
				else
				{
					Console.WriteLine("Invalid choice. Please try again.");
				}

				PrintMenu2();
				userChoice2 = Console.ReadLine()[0];
			}
		}
		private void PrintMenu2()
        {
            Console.WriteLine("[1] Edit Details for client\n" +
                "[2] Edit details for coach\n" +
                "[3] back to menu\n");
            /* "[4] Delete Coach from the system\n >*//*"*/
        }
        private void PrintMenu()
        {
            //Console.Clear();
            Console.Write("Hello and Welcome \n" +
                " [1] New Client register\n" +
                " [2] New Coach register\n" +
                " [3] List of clients\n" +
                " [4] List of coaches\n" +
                " [5] save Client\n" +
                " [6] Save Coach\n" +
                " [7] Enter your user\n" +
                " [8] Update or delete options for management only\n >");


        }
        private void printNameClient(/*Client[] ArrClient*/)
        {
            for (int i = 0; i < ArrClient.Length; i++)
            {
                if (ArrClient[i] == null)
                    continue;
                Console.WriteLine(ArrClient[i].GetFullName());
            }
        }
        private void printNameCoach(/*Coach[] ArrCoach*/)
        {
            for (int i = 0; i < ArrCoach.Length; i++)
            {
                if (ArrCoach[i] == null)
                    continue;
                Console.WriteLine(ArrCoach[i].GetFullName());
            }
        }
        private void SaveClient()
        {
            string output = JsonConvert.SerializeObject(ArrClient);
            File.WriteAllText("saveClient.Json", output);
        }
        private void SaveCoach()
        {
            string output = JsonConvert.SerializeObject(ArrCoach);
            File.WriteAllText("saveCoach.Json", output);
        }
        private void readClient()
        {
            try
            {
                ArrClient = JsonConvert.DeserializeObject<Client[]>(File.ReadAllText("saveClient.json"));
                for (int i = 0; i < ArrClient.Length; i++)
                {
                    if (ArrClient[i] == null)
                    {
                        clientI = i;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                SaveClient(/*true*/);
            }
        }
        private void readCoach()
        {
            try
            {
                ArrCoach = JsonConvert.DeserializeObject<Coach[]>(File.ReadAllText("saveCoach.json"));
                for (int i = 0; i < ArrCoach.Length; i++)
                {
                    if (ArrCoach[i] == null)
                    {
                        coachI = i;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                SaveCoach(/*true*/);
            }
        }
        private Client FindClientByCardToken(string cardToken)// the client here is for the obj im looking for 
        {
            for (int i = 0; i < ArrClient.Length; i++)
            {
                if (ArrClient[i] != null && ArrClient[i].CardToken.CompareTo(cardToken) == 0)
                    return ArrClient[i];
            }
            // Didn't found the client.
            return null;
        }
        private Coach FindCoachByEmpoleeID(string employeeID)
        {
            for (int i = 0; i < ArrCoach.Length; i++)
            {
                if (ArrCoach[i] != null && ArrCoach[i].EmployeeID.CompareTo(employeeID) == 0)
                    return ArrCoach[i];
            }
            return null;
        }
    }
}



