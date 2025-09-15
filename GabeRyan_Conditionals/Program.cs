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


        static void DealDamge(WeaponType weapontype)
        {

            if(weapontype == WeaponType.pistol)
            {

            }
            else if (weapontype == WeaponType.sword)
            {

            }
            else if (weapontype == WeaponType.hammer)
            {

            }
            else if (weapontype == WeaponType.axe)
            {

            }
            else
            {

            }


        }

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
        }

   
        static void ClearLine()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.WriteLine 
        }

      
            



       
        
         
    }     
}

       
