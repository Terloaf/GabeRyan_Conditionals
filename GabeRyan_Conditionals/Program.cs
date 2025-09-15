using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabeRyan_Conditionals
{

    enum WeaponType
    {
        pistol = 0,
        sword = 1,
        hammer = 2,
        axe = 3
    }
       





    internal class Program
    { 
        static int playerHealth = 100;
        static WeaponType weapon = WeaponType.pistol;
        static string characterName = "Guy2";
        
        static void ChangeWeapon(WeaponType NewWeapon)
        {
            weapon = NewWeapon;
        }

        static void TakeDamage(int damage)
        {
            playerHealth -= damage;
        }

        static void Heal(int hp)
        {
            playerHealth += hp;

            if (playerHealth > 100)
            {
                playerHealth = 100;
            }
        }

   
        static void ClearLine()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void ShowHud()
        {
            string characterNameText = "Name: " + characterName;
            string HealthText = "Health: " + playerHealth;
            string WeaponText = "Weapon: " + weapon;

            Console.Write("{0,0}", characterNameText);
            Console.Write("{0,60}", WeaponText);

            if(playerHealth == 100)
            {
                Console.Write("{0,50}", HealthText + " Perfect Health");
            }
            else if (playerHealth >= 75)
            {
                Console.Write("{0,50}", HealthText + " Doing Fine");
            }
            else if(playerHealth >= 50)
            {
                Console.Write("{0,50}", HealthText + " Worse for wear");
            }
            else if(playerHealth >= 25)
            {
                Console.Write("{0,50}", HealthText + " Critically low!");
            }
            else if(playerHealth < 25)
            {
                Console.Write("{0,50}", HealthText + " Imminent Death...");
            }
            


        }
        static void Main(string[] args)
        {
            ShowHud();

            ClearLine();

            Console.WriteLine("Oh no! a Monster's attacked you!");
            ClearLine();
            Console.WriteLine("You took 25 damage...");
            TakeDamage(25);
            ClearLine();

            ShowHud();

            ClearLine();
            Console.WriteLine("Time for a weapon change! switching to sword");
            ChangeWeapon(WeaponType.sword);
            ClearLine();
            ShowHud();

            ClearLine();
            Console.WriteLine("Swing! and.");
            ClearLine();
            Console.WriteLine(".");
            ClearLine();
            Console.WriteLine("..");
            ClearLine();
            Console.WriteLine("...");
            ClearLine();
            Console.WriteLine("Critical Hit! Enemy defeated");
            ClearLine();
            Console.BackgroundColor = ConsoleColor.Red;
            ClearLine();
            Console.BackgroundColor = ConsoleColor.Black;
            ClearLine();
            Console.WriteLine("Surprise attack! you took 48 damage...");
            TakeDamage(48);
            ClearLine();
            ShowHud();
            ClearLine();
            Console.WriteLine("You're swarmed by Monsters use your Hammer!");
            ClearLine();
            ChangeWeapon(WeaponType.hammer);
            ClearLine();
            ShowHud();
            ClearLine();
            Console.WriteLine("WHAM! You took them all out!");
            ClearLine();
            Console.WriteLine("Well... Looks like thats the end of it. Time to finally relax and build that log cabin. Switch to your axe");
            ClearLine();
            ChangeWeapon(WeaponType.axe);
            ClearLine();
            Console.WriteLine("While you were chopping the tree fell over!");
            ClearLine();
            Console.WriteLine("You were crushed by a falling tree... 26 damage...");
            TakeDamage(26);
            ClearLine();
            ShowHud();
            ClearLine();
            Console.WriteLine("Luckily a delicious apple landed right infront of you, so you take a bite and... Full Restore!");
            Heal(99);
            ClearLine();
            ShowHud();
            

            

            
            







        }

      
            



       
        
         
    }     
}

       
