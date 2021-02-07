using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Game myGame = new Game();


            Console.WriteLine("Welcome to Star Wars Simulator VideoGame!");

            bool keepPlaying = true;
            while (keepPlaying)
            {

                bool firstMenu = true;
                while(firstMenu)
                {


                    Console.WriteLine("\nPlease pick your side by entering one (1) for light side, or two (2) for Dark Side:");
                    Console.WriteLine("You are allowed to come back to the main menu to switch sides and deal damage to both sides");
                    Console.WriteLine("\nWhat Side of the Force are you on?");
                    Console.WriteLine("1. Light Side, Peace Overcomes All!");
                    Console.WriteLine("2. The Dark Side, afterall The Sith is way cooler!");
                    Console.WriteLine("3. Check on the Health of the Light Side");
                    Console.WriteLine("4. Check on the Health of the Dark Side");
                    Console.WriteLine("5. Exit the Game");
            

                    string sideChoice = Console.ReadLine();

                    switch (sideChoice)
                    {
                        case "1":
                            Console.WriteLine("Welcome to the side of Peace and Hope!");
                            firstMenu = false;
                            bool lightSide = true;
                            while(lightSide)
                            {

                                Console.WriteLine("\nHere comes the Dark Side! Pick a number to decide what we should do.");
                                Console.WriteLine("1. Check on the Health of our Heros");
                                Console.WriteLine("2. Check on the Health of the Villans");
                                Console.WriteLine("3. Have Luke use his Light Saber");
                                Console.WriteLine("4. Have Luke use Force Push");
                                Console.WriteLine("5. Have Obi-Wan use his light saber");
                                Console.WriteLine("6. Have Obi-Wan use Jedi Mind Tricks");
                                Console.WriteLine("7. Have Han Solo Shoot at the dark Side");
                                Console.WriteLine("8. Let Han Solo get Greedy");
                                Console.WriteLine("9. Abandon mission and exit to the menu.");

                                string lightSideChoice = Console.ReadLine();

                                switch (lightSideChoice)
                                {
                                    case "1":
                                        foreach (String name in myGame.lightSideArray)
                                        {
                                            Console.WriteLine($"\nThe health status of {myGame.lightSideArray[0]} is {myGame.LukeHealth}");
                                            Console.WriteLine($"The health status of {myGame.lightSideArray[1]} is {myGame.ObiWanHealth}");
                                            Console.WriteLine($"The health status of {myGame.lightSideArray[2]} is {myGame.HanSoloHealth}");
                                            break;
                                        }
                                        break;
                                    case "2":
                                        foreach (String name in myGame.darkSideArray)
                                        {
                                            Console.WriteLine($"\nThe health status of {myGame.darkSideArray[0]} is {myGame.DarthSidiousHealth}");
                                            Console.WriteLine($"The health status of {myGame.darkSideArray[1]} is {myGame.DarthVaderHealth}");
                                            Console.WriteLine($"The health status of {myGame.darkSideArray[2]} is {myGame.BobaFettHealth}");
                                            break;
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("\nLuke ignites his Light Saber");
                                        myGame.LukeLightSaberdamage();
                                        Console.WriteLine("Darth Vader took 40 points of damage!");
                                        Console.WriteLine("Darth Sidious took 10 points of damage!");
                                        Console.WriteLine("Boba Fett took 80 point of Damage and nearly fell in the Sarlacc Pit!");
                                        break;
                                    case "4":
                                        Console.WriteLine("\nAs our Heros begin to feel surrounded, Luke uses Force Push to put distance between the two teams.");
                                        myGame.LukeForcePushDamage();
                                        Console.WriteLine("Darth Vader falls back and takes 10 points of damage!");
                                        Console.WriteLine("Darth Sidious falls back and takes 10 points of damage!");
                                        Console.WriteLine("Boba Fett falls back and takes 10 points of damage!");
                                        break;
                                    case "5":
                                        Console.WriteLine("\nObi-Wan Ignites his Light Saber");
                                        myGame.ObiWanLightSaberDamage();
                                        Console.WriteLine("Darth Vader took 60 points of damage!");
                                        Console.WriteLine("Darth Sidious took 20 points of damage!");
                                        Console.WriteLine("Boba Fett took 20 points of damage!");
                                        break;
                                    case "6":
                                        Console.WriteLine("\nObi-Wan uses his Jedi Mind Tricks!");
                                        myGame.JediMindTricks();
                                        Console.WriteLine("Luke Skywalker Gains 30 Health Points!");
                                        Console.WriteLine("Obi-Wan Gains 50 Health Points!");
                                        Console.WriteLine("Han Solo Gains 30 Health Points!");
                                        break;
                                    case "7":
                                        Console.WriteLine("\nHan Shoots his Blaster");
                                        myGame.QuickShot();
                                        Console.WriteLine("Darth Vader took 30 points of damage!");
                                        Console.WriteLine("Darth Sidious took 30 points of damage!");
                                        Console.WriteLine("Boba Fett took 30 points of damage!");
                                        break;
                                    case "8":
                                        Console.WriteLine("\nHan channels his Inner Bounty Hunter and Gets Greedy to Save Himself!");
                                        myGame.Greed();
                                        Console.WriteLine("Luke Skywalker feel abandoned by his old partner and makes a simple mistake, taking 10 damage!");
                                        Console.WriteLine("Obi-Wan gets caught off guard by han's decision and loses focus. Obi-wan takes 10 damage!");
                                        Console.WriteLine("Han Solo Gains 80 Health Points!");
                                        break;
                                    case "9":
                                        Console.WriteLine("\nYou exit to the menu.");
                                        lightSide = false;
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease choose a number");
                                        break;
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("Together We Shall Rule the Galaxy!");
                            firstMenu = false;
                            bool darkSide = true;
                            while (darkSide)
                            {

                                Console.WriteLine("\nHere comes the Rebels! Pick a number to decide what we should do.");
                                Console.WriteLine("1. Check on the Health of our Villans");
                                Console.WriteLine("2. Check on the Health of The Rebel Scum");
                                Console.WriteLine("3. Have Darth Sidious use Force Lightning");
                                Console.WriteLine("4. Have Darth Sidious use Near Immortality Ability");
                                Console.WriteLine("5. Have Darth Vader use his light saber");
                                Console.WriteLine("6. Have Darth Vader use Force Choke");
                                Console.WriteLine("7. Have Boba Fett Shoot at the Rebels");
                                Console.WriteLine("8. Have Boba Fett use his Flame Thrower");
                                Console.WriteLine("9. Abandon mission and exit to the menu.");

                                string darkSideChoice = Console.ReadLine();

                                switch (darkSideChoice)
                                {
                                    case "1":
                                        foreach (String name in myGame.darkSideArray)
                                        {
                                            Console.WriteLine($"\nThe health status of {myGame.darkSideArray[0]} is {myGame.DarthSidiousHealth}");
                                            Console.WriteLine($"The health status of {myGame.darkSideArray[1]} is {myGame.DarthVaderHealth}");
                                            Console.WriteLine($"The health status of {myGame.darkSideArray[2]} is {myGame.BobaFettHealth}");
                                            break;
                                        }
                                        break;
                                    case "2":
                                        foreach (String name in myGame.lightSideArray)
                                        {
                                            Console.WriteLine($"\nThe health status of {myGame.lightSideArray[0]} is {myGame.LukeHealth}");
                                            Console.WriteLine($"The health status of {myGame.lightSideArray[1]} is {myGame.ObiWanHealth}");
                                            Console.WriteLine($"The health status of {myGame.lightSideArray[2]} is {myGame.HanSoloHealth}");
                                            break;
                                        }
                                        break;
                                    case "3":
                                        Console.WriteLine("\nDarth Sidious starts laughing at the weaker foes infront of him. Sparks start flying and madness takes over!");
                                        myGame.ForceLightning();
                                        Console.WriteLine("Darth Vader took 50 points of damage!");
                                        Console.WriteLine("Darth Sidious took 70 points of damage!");
                                        Console.WriteLine("Boba Fett took 50 points of Damage!");
                                        Console.WriteLine("Luke Skywalker took 100 points of damage!");
                                        Console.WriteLine("Obi-Wan took 100 points of damage!");
                                        Console.WriteLine("Han Solo took 100 points of damage!");
                                        break;
                                    case "4":
                                        Console.WriteLine("\nDarth Sidious is Nearly Immortal");
                                        myGame.NearImmortality();
                                        Console.WriteLine("Darth Sidious gains 200 Health Points");
                                        break;
                                    case "5":
                                        Console.WriteLine("\nDarth Vader Ignites his Light Saber");
                                        myGame.VaderLightSaberDamage();
                                        Console.WriteLine("Luke Skywalker took 40 points of damage!");
                                        Console.WriteLine("Obi-Wan took 60 points of damage!");
                                        Console.WriteLine("Han solo took 50 points of damage!");
                                        break;
                                    case "6":
                                        Console.WriteLine("\nDarth Vader uses Force Choke");
                                        myGame.JediMindTricks();
                                        Console.WriteLine("Luke Skywalker takes 20 points in damage");
                                        Console.WriteLine("Obi-Wan takes 30 points in damage");
                                        Console.WriteLine("Han Solo takes 70 points in damage");
                                        break;
                                    case "7":
                                        Console.WriteLine("\nBoba Fett Shoots his Blaster");
                                        myGame.Blaster();
                                        Console.WriteLine("Luke Skywalker takes 30 points in damage");
                                        Console.WriteLine("Obi-Wan takes 30 points in damage");
                                        Console.WriteLine("Han Solo takes 50 points in damage");
                                        break;
                                    case "8":
                                        Console.WriteLine("\nBoba Fett uses his Flame Thrower");
                                        myGame.Greed();
                                        Console.WriteLine("Luke Skywalker takes 40 points in damage");
                                        Console.WriteLine("Obi-Wan takes 30 points in damage");
                                        Console.WriteLine("Han Solo takes 60 points in damage");
                                        break;
                                    case "9":
                                        Console.WriteLine("\nYou exit to the menu.");
                                        darkSide = false;
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease choose a number");
                                        break;
                                }

                            }
                            break;
                        case "3":
                            foreach (String name in myGame.lightSideArray)
                            {
                                Console.WriteLine($"\nThe health status of {myGame.lightSideArray[0]} is {myGame.LukeHealth}");
                                Console.WriteLine($"The health status of {myGame.lightSideArray[1]} is {myGame.ObiWanHealth}");
                                Console.WriteLine($"The health status of {myGame.lightSideArray[2]} is {myGame.HanSoloHealth}");
                                break;
                            }
                            break;
                        case "4":
                            foreach (String name in myGame.darkSideArray)
                            {
                                Console.WriteLine($"\nThe health status of {myGame.darkSideArray[0]} is {myGame.DarthSidiousHealth}");
                                Console.WriteLine($"The health status of {myGame.darkSideArray[1]} is {myGame.DarthVaderHealth}");
                                Console.WriteLine($"The health status of {myGame.darkSideArray[2]} is {myGame.BobaFettHealth}");
                                break;
                            }
                            break;
                        case "5":
                            Console.WriteLine("\nThank You For Playing!");
                            firstMenu = false;
                            keepPlaying = false;
                            break;

                        default:
                            Console.WriteLine("\nNot valid. please choose your side by entering number one (1) or two (2)");
                            break;
                    }
                }
            }
        }
    }
}
