using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.NetworkInformation;

static void Main()
{


    string PW = "admin";
    bool Menu = true;
    while (Menu)
    {
        Console.WriteLine("-------------------Menu-------------------");
        Console.WriteLine("|    A: White Hats                       |");
        Console.WriteLine("|    B: North Korean hackers             |");
        Console.WriteLine("|    C: United Arab Emirates hackers     |");
        Console.WriteLine("|    D: USA Government Agencies          |");
        Console.WriteLine("|    E: Italian 'Hacking Team'           |");
        Console.WriteLine("|    F: NSO - Israeli hackers            |");
        Console.WriteLine("|    !: Rules for GM                     |");
        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Choose your organization by entering the letter associated with it in the menu: ");
        string input = Console.ReadLine();

        if (input == "A" | input == "a")
        {
            /*RUN WHITE HATS*/
            WhiteHats();
            
            Menu = false;
        }
        else if (input == "B" | input == "b")
        {
            /*RUN NK*/
            NorthKorea();
            
            Menu = false;
        }
        else if (input == "C" | input == "c")
        {
            /*RUN UAE*/
            UAE();
      
            Menu = false;
        }
        else if (input == "D" | input == "d")
        {
            /*RUN US*/
            USA();
            
            Menu = false;
        }
        else if (input == "E" | input == "e")
        {
            /*RUN HACKING TEAM*/
            Italian_Hacking_Team();
           
            Menu = false;
        }
        else if (input == "F" | input == "f")
        {
            /*RUN NSO*/
            NSO();
            
            Menu = false;
        }
        else if (input == "!")
        {
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            if (password == PW)
            {
                Rules();
                break;
            }
            else
            {
                Console.WriteLine("Try Again");
                continue;
            
            }
        }
        else
        {
            Console.WriteLine("Incorrect Input");
            continue;
        }


    }
    
       

}

static void Rules()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nSetting Up The Game:\nSeperate class into groups of 4.\n\nOnce seperated, groups should pick an alignment from the choices given:\nLawful Neutral(1)\nChaotic Evil(1)\nNeutral Evil(2)\nLawful Evil(2)\n\nOnce groups have picked their alignments, assign hacker orgs:\nLawful Neutral: White Hats\nChaotic Evil: Italian 'Hacking Team'\nNeutral Evil: NSO, United Arab Emirates\nLawful Evil: USA, North Korea\n");
    Console.WriteLine("Winning The Game: Each team starts with 5 Reputation points, 5 HP, and 1500 time and money points. Throughout the game, the more reputation points you lose, the more you stray from you original alignment. If HP reaches 0, your government has failed the cyber arms race and you lose. An average of all points will be taken at the end of the game for those that still have HP left to signify the winner. 503 is a perfect score.\n");
    Console.WriteLine("Playing The Game: Each round will start off with 4 choices: Hack, Alliance, Political, or Counter\nHack: Attack another group with a cyberweapon\nAlliance: Become friendly with another group, may cost reputation points depending on the group\nPolitical: Gain the trust of your nations' people, this helps you maintain power and reputation points\n Counter: Defend against a possible attack, lasts for a round, costs time and money points\n");
    Console.WriteLine("More On HACKING: Each team has a specific hacking style:\nWhite Hats: Ethical Hacking\nNorth Korea: Social Engineering\nUAE: Backdoors\nUSA: Collecting Zero Days\nNSO: Phone Surveillance\nHacking Group: Widespread Breaches\n\nEach team, with their unique hacking style will be able to attack other teams for damage. Attack on your turn for 1 damage point on your opponent.\n");
    Console.WriteLine("More on ALLIANCE: You can ally with 1 other team for strategy purposes, but be aware that certain groups allignments will knock you down by 1 reputation point if they dont allign correctly. You will have 30 seconds each to state why you should be allies. If the other team says no after conversing, then the allyship is off and the next group plays.\n");
    Console.WriteLine("More on POLITICAL: You can create propaganda for your followers or members of you nation by spending time and money points, this action can gain back a reputation point. Be careful, there is no way to gain back time or money until the next round.");
    Console.WriteLine("More on COUNTER: You can choose to counter an attack by upgrading your own organizations defenses with time and money points. This keeps you from being attacked for a whole turn.");
    Console.ForegroundColor = ConsoleColor.White;
}

static void WhiteHats()
{

    List<string> org = new List<string>();
    int round = 1;
    
    bool counter_was_picked = false;
 
    int rep_points = 5;
    int hp = 5;
    bool is_safe_for_round = false;
    int t_m_points = 1500;
    while (round <= 10)
    {
        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if(hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }
        
        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if(counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //NEW: changed the character color red for team label and alignment level
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE WHITE HATS");
        
        Console.WriteLine("\nAlignment: Lawful Neutral");
        

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nROUND: {round}\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();


        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. North Korean hackers");
            Console.WriteLine("2. United Arab Emirates hackers");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Israeli hackers\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the North Korean network... -1 to North Korean hackers HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the UAE network... -1 to UAE hackers' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the USA network... -1 to USA HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the Hacking Team network... -1 to Italian Hacking Team's HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the NSO network... -1 to NSO's HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);

                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. North Korean hackers");
            Console.WriteLine("2. United Arab Emirates hackers");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Isreali hackers\n");

            Console.WriteLine("SUGGESTED ALLIES FOR WHITE HATS:");
            Console.WriteLine("White Hats --> USA Government Agencies (Nuetral Evil)");
            Console.WriteLine("White Hats --> NSO - Isreali hackers (Neutral Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to North Korea as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("North Korea ");
                    Console.WriteLine("You are now Allies with North Korea.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with North Korea.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to UAE as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("UAE ");
                    Console.WriteLine("You are now Allies with United Arab Emirates.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with United Arab Emirates.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to USA as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("USA ");
                    Console.WriteLine("You are now Allies with USA.\n");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with USA.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to 'Hacking Team' as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team ");
                    Console.WriteLine("You are now Allies with 'Hacking Team'.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with 'Hacking Team'.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to NSO as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO ");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }
            }

        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 health points");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            continue;


        }
        else if (choice == "4")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if(t_m_points < 250)
            {
                Console.WriteLine("You can not complete this action, you do not have enough Time and Money Points");
                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            counter_was_picked = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);

            continue;


        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {

                if (hp == 0 && rep_points > 0 && t_m_points > 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp==0 && rep_points == 0 && t_m_points > 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. North Korean hackers");
                Console.WriteLine("2. United Arab Emirates hackers");
                Console.WriteLine("3. USA Government Agencies");
                Console.WriteLine("4. Italian 'Hacking Team'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR WHITE HATS:");
                Console.WriteLine("White Hats --> USA Government Agencies (Nuetral Evil)");
                Console.WriteLine("White Hats --> NSO - Isreali hackers (Neutral Evil)\n");


                string des = Console.ReadLine();

                if(des == "1")
                {
                    org.Add("North Korean Hackers ");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with North Korea");
                    continue;
                }
                else if(des == "2")
                {
                    org.Add("UAE ");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with UAE");
                    continue;
                }
                else if(des == "3")
                {
                    org.Add("USA ");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;
                }
                else if(des == "4")
                {
                    org.Add("Italian 'Hacking Team' ");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;

                }
                else if(des == "5")
                {
                    org.Add("NSO ");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }

            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if(choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if(next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if(next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }

    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");
}


static void NorthKorea()
{

    List<string> org = new List<string>();
    int round = 1;
    bool counter_was_picked = false;
    int rep_points = 5;
    int hp = 5;
    int t_m_points = 1500;
    bool is_safe_for_round = false;
    while (round <= 10)
    {

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }

        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if (counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE NORTH KOREA");

        Console.WriteLine("\nAlignment: Lawful Evil");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ROUND: {round}\n\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        is_safe_for_round = false;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();



        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. White Hats");
            Console.WriteLine("2. United Arab Emirates hackers");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Israeli hackers\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the White Hat network... -1 to the White Hat HP");
                Thread.Sleep(2000);

                continue;
                
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the UAE network... -1 to UAE hackers' HP");
                Thread.Sleep(2000);

                continue;

            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the USA network... -1 to USA's HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the Hacking Team network... -1 to Italian Hacking Team's HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the NSO network... -1 to NSO's HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);

                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            //START HERE

            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. White Hats");
            Console.WriteLine("2. United Arab Emirates hackers");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Isreali hackers\n");

            Console.WriteLine("SUGGESTED ALLIES FOR NORTH KOREA:");
            Console.WriteLine("North Korea --> Italian 'Hacking Team' (Chaotic Evil)");
            Console.WriteLine("North Korea --> United Arab Emirates (Neutral Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to the White Hats as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("White Hats ");
                    Console.WriteLine("You are now Allies with the White Hats.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with the White Hats.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to UAE as to why you should be allies in 30 seconds...");

                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("UAE ");
                    Console.WriteLine("You are now Allies with United Arab Emirates.\n");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with United Arab Emirates.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to USA as to why you should be allies in 30 seconds...");

                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("USA ");
                    Console.WriteLine("You are now Allies with USA.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with USA.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to 'Hacking Team' as to why you should be allies in 30 seconds...");

                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team ");
                    Console.WriteLine("You are now Allies with 'Hacking Team'.\n");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with 'Hacking Team'.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to NSO as to why you should be allies in 30 seconds...");

                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO ");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);

                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);

                    continue;
                }
            }

        }
        else if (choice == "3")
        {

            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation points");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 HP");
            }

            Thread.Sleep(2000);

            continue;


        }
        else if (choice == "4")
        {
            if (t_m_points < 250)
            {
                Console.WriteLine("You can not complete this action, you do not have enough Time and Money Points");
                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            counter_was_picked = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Thread.Sleep(2000);

            continue;

        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {
                if (hp == 0 && rep_points > 0 && t_m_points > 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points > 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            //CONTINUE TO CHANGE THE ALLY TEAMS FOR THIS SECTION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. White Hats");
                Console.WriteLine("2. United Arab Emirates hackers");
                Console.WriteLine("3. USA Government Agencies");
                Console.WriteLine("4. Italian 'Hacking Team'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR NORTH KOREA:");
                Console.WriteLine("North Korea --> USA Government Agencies (Nuetral Evil)");
                Console.WriteLine("North Korea --> NSO - Isreali hackers (Neutral Evil)\n");


                string des = Console.ReadLine();

                if (des == "1")
                {
                    org.Add("White Hats");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with North Korea");
                    continue;
                }
                else if (des == "2")
                {
                    org.Add("UAE");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with UAE");
                    continue;
                }
                else if (des == "3")
                {
                    org.Add("USA");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;
                }
                else if (des == "4")
                {
                    org.Add("Italian 'Hacking Team'");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;

                }
                else if (des == "5")
                {
                    org.Add("NSO");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if (choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if (next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if (next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }
    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");
}

static void UAE()
{

    List<string> org = new List<string>();
    int round = 1;
    bool counter_was_picked = false;
    int rep_points = 5;
    int hp = 5;
    int t_m_points = 1500;
    bool is_safe_for_round = false;
    while (round <= 10)
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }

        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if (counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE UNITED ARAB EMIRATES");

        Console.WriteLine("\nAlignment: Neutral Evil");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ROUND: {round}\n\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        is_safe_for_round = false;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();



        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Israeli hackers\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the North Korean network... -1 to North Korean hackers HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the White Hats network... -1 to White Hats hackers' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the USA network... -1 to USA HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the Hacking Team network... -1 to 'Hacking Team' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the NSO network... -1 to NSO HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);

                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. USA Government Agencies");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Isreali hackers\n");

            Console.WriteLine("SUGGESTED ALLIES FOR UAE:");
            Console.WriteLine("UAE --> USA Government Agencies (Nuetral Evil)");
            Console.WriteLine("UAE --> NSO - Isreali hackers (Neutral Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to North Korea as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You are now Allies with North Korea.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with North Korea.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to White Hats as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("White Hats");
                    Console.WriteLine("You are now Allies with White Hats.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with White Hats.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to USA as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("USA");
                    Console.WriteLine("You are now Allies with USA.\n");
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with USA.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to 'Hacking Team' as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team");
                    Console.WriteLine("You are now Allies with 'Hacking Team'.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with 'Hacking Team'.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to NSO as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }

        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation points");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 health points");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "4")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points < 250)
            {
                Console.WriteLine("You can not complete this action, you do not have enough Time and Money Points");
                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            counter_was_picked = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {
                if (hp == 0 && rep_points > 0 && t_m_points > 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points > 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. White Hats");
                Console.WriteLine("2. North Korean Hackers");
                Console.WriteLine("3. USA Government Agencies");
                Console.WriteLine("4. Italian 'Hacking Team'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR WHITE HATS:");
                Console.WriteLine("UAE --> USA Government Agencies (Nuetral Evil)");
                Console.WriteLine("UAE --> NSO - Isreali hackers (Neutral Evil)\n");


                string des = Console.ReadLine();

                if (des == "1")
                {
                    org.Add("White Hats");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with North Korea");
                    continue;
                }
                else if (des == "2")
                {
                    org.Add("North Korea");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with UAE");
                    continue;
                }
                else if (des == "3")
                {
                    org.Add("USA");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;
                }
                else if (des == "4")
                {
                    org.Add("Italian 'Hacking Team'");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;

                }
                else if (des == "5")
                {
                    org.Add("NSO");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if (choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if (next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if (next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }
    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");
}

static void USA()
{

    List<string> org = new List<string>();
    int round = 1;
    bool counter_was_picked = false;
    int rep_points = 5;
    int hp = 5;
    int t_m_points = 1500;
    bool is_safe_for_round = false;
    while (round <= 10)
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }

        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if (counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE USA");

        Console.WriteLine("\nAlignment: Lawful Evil");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ROUND: {round}\n\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        is_safe_for_round = false;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();



        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Israeli hackers\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the North Korean network... -1 to North Korean hackers HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the White Hats network... -1 to White Hats hackers' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the UAE network... -1 to UAE HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the 'Hacking Team' network... -1 to 'Hacking Team' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the NSO network... -1 to NSO HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);

                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. Italian 'Hacking Team'");
            Console.WriteLine("5. NSO - Isreali hackers\n");

            Console.WriteLine("SUGGESTED ALLIES FOR USA:");
            Console.WriteLine("USA --> White Hats (Lawful Neutral)");
            Console.WriteLine("USA --> NSO - Isreali hackers (Neutral Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to North Korea as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You are now Allies with North Korea.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);

                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with North Korea.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to White Hats as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("White Hats");
                    Console.WriteLine("You are now Allies with White Hats.\n");
                   
                    Console.WriteLine("Continue to the next round? (Don't do so until everyone is ready)\n");
                    Console.WriteLine("( Y )");
                    string y_o_n = Console.ReadLine();

                    if (y_o_n == "Y" | y_o_n == "y")
                    {
                        round++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input\n");
                    }
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with White Hats.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to UAE as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("UAE");
                    Console.WriteLine("You are now Allies with UAE.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Console.WriteLine("Continue to the next round? (Don't do so until everyone is ready)\n");
                    Console.WriteLine("( Y )");
                    string y_o_n = Console.ReadLine();

                    if (y_o_n == "Y" | y_o_n == "y")
                    {
                        round++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input\n");
                        Thread.Sleep(2000);
                        continue;
                    }
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with UAE.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to 'Hacking Team' as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team");
                    Console.WriteLine("You are now Allies with 'Hacking Team'.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with 'Hacking Team'.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to NSO as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }

        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation points");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 health points");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "4")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points < 250)
            {
                Console.WriteLine("You can not complete this action, you do not have enough Time and Money Points");
                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            counter_was_picked = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {

                if (hp == 0 && rep_points > 0 && t_m_points > 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points > 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. White Hats");
                Console.WriteLine("2. United Arab Emirates hackers");
                Console.WriteLine("3.North Korea");
                Console.WriteLine("4. Italian 'Hacking Team'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR USA:");
                Console.WriteLine("USA --> White Hats (Lawful Neutral)");
                Console.WriteLine("USA --> NSO - Isreali hackers (Neutral Evil)\n");


                string des = Console.ReadLine();

                if (des == "1")
                {
                    org.Add("White Hats");
                    Console.WriteLine("You have agreed to ally with White Hats");
                    continue;
                }
                else if (des == "2")
                {
                    org.Add("UAE");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with UAE");
                    continue;
                }
                else if (des == "3")
                {
                    org.Add("North Korea");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;
                }
                else if (des == "4")
                {
                    org.Add("Italian 'Hacking Team'");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;

                }
                else if (des == "5")
                {
                    org.Add("NSO");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if (choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if (next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if (next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }
    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");
}

static void Italian_Hacking_Team()
{

    List<string> org = new List<string>();
    int round = 1;
    bool counter_was_picked = false;
    int rep_points = 5;
    int hp = 5;
    int t_m_points = 1500;
    bool is_safe_for_round = false;
    while (round <= 10)
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }

        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if (counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE ITALIAN 'HACKING TEAM'");

        Console.WriteLine("\nAlignment: Chaotic Evil");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ROUND: {round}\n\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        is_safe_for_round = false;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();



        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. USA");
            Console.WriteLine("5. NSO - Israeli hackers\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the North Korean network... -1 to North Korean hackers HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the White Hats network... -1 to White Hats hackers' HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the UAE network... -1 to UAE HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the USA network... -1 to USA HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the NSO network... -1 to NSO HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);
                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. USA");
            Console.WriteLine("5. NSO - Isreali hackers\n");

            Console.WriteLine("SUGGESTED ALLIES FOR 'HACKING TEAM':");
            Console.WriteLine("'Hacking Team' --> North Korea (Lawful Evil)");
            Console.WriteLine("'Hacking Team' --> UAE (Neutral Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to North Korea as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You are now Allies with North Korea.\n");

                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with North Korea.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to White Hats as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("White Hats");
                    Console.WriteLine("You are now Allies with White Hats.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with White Hats.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to UAE as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("UAE");
                    Console.WriteLine("You are now Allies with UAE.\n");

                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with UAE.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to USA as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team");
                    Console.WriteLine("You are now Allies with USA.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with USA.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to NSO as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }

        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation points");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 health points");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "4")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            if(t_m_points < 250)
            {
                Console.WriteLine("You don't have enough time and money points to complete this action");
                Thread.Sleep(2000);

                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            is_safe_for_round = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {

                
                if(hp == 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if(hp == 0 && rep_points == 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if(hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. White Hats");
                Console.WriteLine("2. United Arab Emirates hackers");
                Console.WriteLine("3. North Korea");
                Console.WriteLine("4. USA'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR 'HACKING TEAM':");
                Console.WriteLine("Italian 'Hacking Team' --> North Korea (Lawful Evil)");
                Console.WriteLine("Italian 'Hacking Team' --> UAE (Neutral Evil)\n");


                string des = Console.ReadLine();

                if (des == "1")
                {
                    org.Add("White Hats");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with White Hats");
                    continue;
                }
                else if (des == "2")
                {
                    org.Add("UAE");
                    Console.WriteLine("You have agreed to ally with UAE");
                    continue;
                }
                else if (des == "3")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You have agreed to ally with North Korea");
                    continue;
                }
                else if (des == "4")
                {
                    org.Add("USA");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;

                }
                else if (des == "5")
                {
                    org.Add("NSO");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if (choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if (next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if (next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }

    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");

}

//Change continue if statement in each section
static void NSO()
{

    List<string> org = new List<string>();
    int round = 1;
    bool counter_was_picked = false;
    int rep_points = 5;
    int hp = 5;
    int t_m_points = 1500;
    bool is_safe_for_round = false;
    while (round <= 10)
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (hp == 0 && rep_points == 0 && t_m_points <= 0)
        {
            Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
            Thread.Sleep(2000);

            break;
        }

        //Claude AI
        // If counter was picked last round, activate protection for this round
        // and clear the pending flag. Otherwise, protection is off.
        if (counter_was_picked == true)
        {
            is_safe_for_round = true;
            counter_was_picked = false;
        }
        else
        {
            is_safe_for_round = false;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("YOUR TEAM IS THE NSO");

        Console.WriteLine("\nAlignment: Neutral Evil");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"ROUND: {round}\n\n");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("My Turn Stats:\n");
        Console.WriteLine("My Allies:");
        foreach (string item in org)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine($"\nReputation Points: {rep_points}");
        Console.WriteLine($"Health Points: {hp}");
        Console.WriteLine($"Time and Money Points: {t_m_points}\n");
        Console.WriteLine($"Counter on?: {is_safe_for_round}\n");
        Console.WriteLine("------------------------------------------------");

        is_safe_for_round = false;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("My Turn Choices: \n");

        Console.WriteLine("1.Hack");
        Console.WriteLine("2.Alliance");
        Console.WriteLine("3.Political");
        Console.WriteLine("4.Counter\n\n");

        Console.WriteLine("During Oppenents Turns:\n");

        Console.WriteLine("5. An Opponent Attacked My Team!");
        Console.WriteLine("6. Another Team Wants to Ally!\n");
        Console.WriteLine("7. NEXT TURN\n");

        Console.WriteLine("What choice will you make this round? Enter the number...\n");
        string choice = Console.ReadLine();



        if (choice == "1")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you hacking?\n");
            Console.WriteLine("1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. USA");
            Console.WriteLine("5. Italian 'Hacking Team'\n");
            Console.ForegroundColor = ConsoleColor.White;

            string team = Console.ReadLine();


            if (team == "1")
            {
                Console.WriteLine("You have infiltrated the North Korean network... -1 to North Korean hackers HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "2")
            {
                Console.WriteLine("You have infiltrated the White Hats network... -1 to White Hats hackers' HP");

                Thread.Sleep(2000);
                continue;
            }
            else if (team == "3")
            {
                Console.WriteLine("You have infiltrated the UAE network... -1 to UAE HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "4")
            {
                Console.WriteLine("You have infiltrated the USA network... -1 to USA HP");

                Thread.Sleep(2000);

                continue;
            }
            else if (team == "5")
            {
                Console.WriteLine("You have infiltrated the Italian 'Hacking Team' network... -1 to Italian 'Hacking Team' HP");

                Thread.Sleep(2000);

                continue;
            }
            else
            {
                Console.WriteLine("Incorrect Input\n");
                Thread.Sleep(2000);

                continue;
            }
        }
        else if (choice == "2")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Which team are you joining an alliance with?");

            Console.WriteLine("\n1. North Korean hackers");
            Console.WriteLine("2. White Hats");
            Console.WriteLine("3. United Arab Emirates");
            Console.WriteLine("4. USA");
            Console.WriteLine("5. Italian 'Hacking Team'\n");

            Console.WriteLine("SUGGESTED ALLIES FOR NSO:");
            Console.WriteLine("NSO --> North Korea (Lawful Evil)");
            Console.WriteLine("NSO --> USA (Lawful Evil)");
            string ally = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            if (ally == "1")
            {
                Console.WriteLine("Present your claim to North Korea as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You are now Allies with North Korea.\n");

                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with North Korea.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }

            }
            if (ally == "2")
            {
                Console.WriteLine("Present your claim to White Hats as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("White Hats");
                    Console.WriteLine("You are now Allies with White Hats.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with White Hats.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "3")
            {
                Console.WriteLine("Present your claim to UAE as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("UAE");
                    Console.WriteLine("You are now Allies with UAE.\n");

                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with UAE.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            if (ally == "4")
            {
                Console.WriteLine("Present your claim to USA as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("Hacking Team");
                    Console.WriteLine("You are now Allies with USA.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with USA.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }
            /*Add code next*/
            if (ally == "5")
            {
                Console.WriteLine("Present your claim to Italian 'Hacking Team' as to why you should be allies in 30 seconds, countdown will begin in...");

                Thread.Sleep(1500);
                Console.WriteLine("3\n");
                Thread.Sleep(1500);
                Console.WriteLine("2\n");
                Thread.Sleep(1500);
                Console.WriteLine("1\n");
                Thread.Sleep(1500);
                Console.WriteLine("GOOOOO!!!\n");

                Thread.Sleep(30000);
                Console.WriteLine("Did they say yes? (Y or N)");
                string ally_choice = Console.ReadLine();

                if (ally_choice == "Y" | ally_choice == "y")
                {
                    org.Add("NSO");
                    Console.WriteLine("You are now Allies with NSO.\n");
                    if (rep_points >= 1)
                    {
                        rep_points = rep_points - 1;
                        Console.WriteLine("-1 reputation points\n");
                    }
                    else
                    {
                        rep_points = 0;
                        Console.WriteLine("You are already at 0 reputation points\n");
                    }
                    Thread.Sleep(2000);
                    continue;
                }
                else if (ally_choice == "N" | ally_choice == "n")
                {
                    Console.WriteLine("You were unsuccessful in allying with NSO.");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                    Thread.Sleep(2000);
                    continue;
                }
            }

        }
        else if (choice == "3")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points >= 120)
            {
                t_m_points = t_m_points - 120;
                Console.WriteLine("-120 time and money points");
            }
            else
            {
                Console.WriteLine("You are already at less than 120 time and money points");
                Console.WriteLine("You can not complete this action.");
                Thread.Sleep(2000);
                continue;
            }


            Console.WriteLine("Choose a representative to present your propoganda to your followers and allies.\n");
            Thread.Sleep(3000);
            Console.WriteLine("To continue after finishing statement, press 'Y'\n");

            if (rep_points >= 0 && rep_points < 5)
            {
                rep_points = rep_points + 1;
                Console.WriteLine("+1 reputation point");
            }
            else
            {
                rep_points = 5;
                Console.WriteLine("You are already at 5 reputation points");
            }

            if (hp >= 0 && hp < 5)
            {
                hp = hp + 1;
                Console.WriteLine("+1 HP");
            }
            else
            {
                hp = 5;
                Console.WriteLine("You are already at 5 health points");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "4")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (t_m_points < 250)
            {
                Console.WriteLine("You can not complete this action, you do not have enough Time and Money Points");
                continue;
            }
            Console.WriteLine("-250 time and money points");
            t_m_points = t_m_points - 250;
            counter_was_picked = true;
            Console.WriteLine("You are countering for this next turn rotation");
            Console.WriteLine("Until your next turn, no one can attack you.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(2000);
            continue;


        }
        else if (choice == "5")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been attacked by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string attack = Console.ReadLine();
            if (attack == "Y" | attack == "y")
            {

                if (hp == 0 && rep_points > 0 && t_m_points > 0)
                {
                    rep_points = rep_points - 1;
                    Console.WriteLine("Reputation Points - 1, you have no health left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points > 0)
                {
                    t_m_points = t_m_points - 50;
                    Console.WriteLine("Time and Money Points -50, you have no health or reputation left");
                    Thread.Sleep(2000);

                    continue;
                }
                else if (hp == 0 && rep_points == 0 && t_m_points == 0)
                {
                    Console.WriteLine("Your organization has crumbled under the pressure of cyber warefare, you have lost the game...");
                    Thread.Sleep(2000);

                    return;
                }
                hp--;
                Console.WriteLine("HP -1");
                continue;
            }
            else if (attack == "N" | attack == "n")
            {
                continue;
            }

;
        }
        else if (choice == "6")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Are you sure that you have been asked to ally by an enemy team?");
            Console.WriteLine("Y or N");
            Console.ForegroundColor = ConsoleColor.White;
            string alliance = Console.ReadLine();
            if (alliance == "Y" | alliance == "y")
            {
                Console.WriteLine("Which Team is allying with you?");
                Console.WriteLine("\n1. White Hats");
                Console.WriteLine("2. United Arab Emirates hackers");
                Console.WriteLine("3. North Korea");
                Console.WriteLine("4. USA'");
                Console.WriteLine("5. NSO - Isreali hackers\n");
                Console.WriteLine("SUGGESTED ALLIES FOR NSO:");
                Console.WriteLine("NSO --> North Korea (Lawful Evil)");
                Console.WriteLine("NSO --> USA (Lawful Evil)\n");
                
                //DO ALLY SWITCH


                string des = Console.ReadLine();

                if (des == "1")
                {
                    org.Add("White Hats");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with White Hats");
                    Thread.Sleep(2000);
                    continue;
                }
                else if (des == "2")
                {
                    org.Add("UAE");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with UAE");
                    Thread.Sleep(2000);
                    continue;
                }
                else if (des == "3")
                {
                    org.Add("North Korea");
                    Console.WriteLine("You have agreed to ally with USA");
                    continue;
                }
                else if (des == "4")
                {
                    org.Add("USA");
                    Console.WriteLine("You have agreed to ally with NSO");
                    Thread.Sleep(2000);
                    continue;
                }
                else if (des == "5")
                {
                    org.Add("Italian 'Hacking Team'");
                    rep_points = rep_points - 1;
                    Console.WriteLine("-1 reputation point");
                    Console.WriteLine("You have agreed to ally with NSO");
                    Thread.Sleep(2000);
                    continue;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else if (alliance == "N" | alliance == "n")
            {
                continue;
            }



        }
        else if (choice == "7")
        {
            Console.WriteLine("You are about to move onto the next round...Are you sure? (Y/N)");
            string next_round = Console.ReadLine();
            if (next_round == "Y" | next_round == "y")
            {
                round++;
                continue;
            }
            else if (next_round == "N" | next_round == "n")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Thread.Sleep(2000);
                continue;
            }
        }
    }
    Console.WriteLine("10 rounds are over, calculating avarage...");
    Thread.Sleep(3000);
    int avg = (rep_points + hp + t_m_points) / 3;
    Console.WriteLine($"Average points: {avg}");
}



Main();