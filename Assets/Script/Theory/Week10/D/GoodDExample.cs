using System;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

namespace Theory.Week10
{

    public class GoodDExample : MonoBehaviour
    {
        public abstract class Enemy
        {
            public virtual void Spawn()
            {


            }
            public virtual void PerformAction()
            {

            }
        }
        public class Goblin : Enemy
        {
            public override void Spawn()
            {
                base.Spawn();
                Debug.Log("Goblin spawn");
            }

            public override void PerformAction()
            {
                base.PerformAction();
                Debug.Log("Goblin Perform action");
            }
        }

        public class Orc : Enemy
        {
            public override void Spawn()
            {
                base.Spawn();
                Debug.Log("Orc spawn");
            }

            public override void PerformAction()
            {
                base.PerformAction();
                Debug.Log("Orc Perform action");
            }
        }

        private void Start()
        {
            Enemy goblinEnemy = new Goblin();
            goblinEnemy.Spawn();
            goblinEnemy.Spawn();

            Enemy orcEnemy = new Orc();
            orcEnemy.Spawn();
            orcEnemy.Spawn();
        }

        private Enemy enemy;
        public void StartWave()
        {
            enemy.Spawn();
            enemy.PerformAction();

        }
    }
}

  
