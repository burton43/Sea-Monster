
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace MonsterClasses

{

    class Program

    {

        static void Main(string[] args)

        {

            DisplayOpeningScreen();

            DisplayMenu();

            DisplayClosingScreen();

        }





        /// <summary>

        /// display opening screen

        /// </summary>

        static void DisplayOpeningScreen()

        {

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("\t\tWelcome to Simple Monster Classes");

            Console.WriteLine();



            DisplayContinuePrompt();

        }



        static SeaMonster InitializeSeaMonsterSid(string name)

        {
            SeaMonster sid = new SeaMonster("Sid");
            sid.Weight = 2.5;
            sid.CanUseFreshWater = true;
            sid.CurrentEmotionalState = SeaMonster.EmotionalState.Sad;
            sid.HomeSea = "caspian";


            return sid;
        }



        static SeaMonster InitializeSeaMonsterSuzy()

        {
            SeaMonster suzy = new SeaMonster();

            suzy.Name = "suzy";
            suzy.Weight = 1.2;
            suzy.CanUseFreshWater = true;
            suzy.CurrentEmotionalState = SeaMonster.EmotionalState.Happy;
            suzy.HomeSea = "caspian";

            return suzy;
        }



        static void DisplaySeaMonsterInfo(List<SeaMonster> seaMonsters)

        {
            string userResponse;
            DisplayHeader("Display Sea Monster Info");

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }
            Console.Write("Enter Name:");
            userResponse = Console.ReadLine();

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
                Console.WriteLine(seaMonster.Weight);
                Console.WriteLine(seaMonster.CanUseFreshWater);
                Console.WriteLine(seaMonster.CurrentEmotionalState);
                Console.WriteLine(seaMonster.HomeSea);
            }

            DisplayContinuePrompt();
        }

        static void DisplayDeleteSeaMonsterInfo(List<SeaMonster> seaMonsters)

        {
            string userResponse;
            DisplayHeader("Delete Sea Monster Info");

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }
            Console.Write("Enter Name:");
            userResponse = Console.ReadLine();

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                seaMonsters.Remove(userResponse);
            }

            DisplayContinuePrompt();
        }

        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)

        {
            DisplayHeader("List of sea Monsters");

            foreach (SeaMonster monster in seaMonsters)
            {
                Console.WriteLine(monster.SeaMonsterAttitude());
            }


            DisplayContinuePrompt();
        }



        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)

        {
            SeaMonster newSeaMonster = new SeaMonster();

            DisplayHeader("add a seamonster");

            Console.Write("Enter name of new seamonster:");
            newSeaMonster.Name = Console.ReadLine();
            Console.Write("Enter home sea of new seamonster:");
            newSeaMonster.HomeSea = Console.ReadLine();
            Console.Write("Enter Weight");
            double.TryParse(Console.ReadLine(), out double weight);
            newSeaMonster.Weight = weight;
            Console.Write("Can use freshwater?");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                newSeaMonster.CanUseFreshWater = true;
            }
            else
            {
                newSeaMonster.CanUseFreshWater = false;
            }
            Console.Write("Enter Emotional State");
            Enum.TryParse(Console.ReadLine(), out SeaMonster.EmotionalState emotionalState);
            newSeaMonster.CurrentEmotionalState = emotionalState;

            seaMonsters.Add(newSeaMonster);

            DisplayContinuePrompt();
        }



        static void DisplayMenu()

        {

            //

            // instantiate sea monsters

            //

            SeaMonster suzy;
            suzy = InitializeSeaMonsterSuzy();
            SeaMonster sid;
            sid = InitializeSeaMonsterSid("Sid");


            //

            // add sea monsters to list

            //
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            seaMonsters.Add(suzy);
            seaMonsters.Add(sid);

            string menuChoice;

            bool exiting = false;



            while (!exiting)

            {

                DisplayHeader("Main Menu");



                Console.WriteLine("\tA) Display All Sea Monsters");

                Console.WriteLine("\tB) User Add a Sea Monster");

                Console.WriteLine("\tC) Display Sea Monster Info");

                Console.WriteLine("\tE) Delete a Sea monster");

                Console.WriteLine("\tF) Exit");



                Console.Write("Enter Choice:");

                menuChoice = Console.ReadLine();



                switch (menuChoice)

                {

                    case "A":

                    case "a":
                        DisplayAllSeaMonsters(seaMonsters);


                        break;



                    case "B":

                    case "b":

                        DisplayGetUserSeaMonster(seaMonsters);

                        break;



                    case "C":

                    case "c":

                        DisplaySeaMonsterInfo(seaMonsters);

                        break;



                    case "D":

                    case "d":

                        DisplayDeleteSeaMonsterInfo(seaMonsters);

                        break;



                    case "E":

                    case "e":



                        break;



                    case "F":

                    case "f":

                        exiting = true;

                        break;



                    default:

                        break;

                }

            }

        }



        /// <summary>

        /// display closing screen

        /// </summary>

        static void DisplayClosingScreen()

        {

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("\t\tThanks for using Simple Monster Classes.");

            Console.WriteLine();



            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }



        /// <summary>

        /// display continue prompt

        /// </summary>

        static void DisplayContinuePrompt()

        {

            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

        }



        /// <summary>

        /// display header

        /// </summary>

        static void DisplayHeader(string headerTitle)

        {

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("\t\t" + headerTitle);

            Console.WriteLine();

        }



    }

}
