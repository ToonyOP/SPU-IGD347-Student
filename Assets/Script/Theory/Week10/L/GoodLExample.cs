using System;
using UnityEngine;

public class GoodLExample : MonoBehaviour
{

    public class Animal // คลาสพื้นฐานสำหรับสัตว์
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Bird:Animal
    {
        public virtual void LayEgg()
        {
            Debug.Log("Lay egg action");
        }
    }

    
   
    /*public class Penguin : Bird
    {
        Bird penguin; = new Bird();
        Penguin

    }*/
    interface IFlyable
    {
        void Fly();
    }

    public class Seagull : Bird, IFlyable // Example use of Interface, IPickupAble,  IDamageAble // implement the interface Class To pick up the Seagull and  the Interface class to damage the player with the Seagull. this is because the other bird wont be naturally agressive//
    {
        public void Fly()
        {
            Debug.Log("Fly action");
        }
    }

    private void Start()
    {
        Bird penguin = new Bird();
        penguin.Eat();
        penguin.LayEgg();
    }
}
