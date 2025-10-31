using UnityEngine;

public class GoodIExample : MonoBehaviour
{
    interface IMeleeSkill
    {
        void PhysicalAttack();
        void UseShield();
    }

    interface IMagicSkill
    {
        void CastSpell(string spellName);
        void CheckMana();
    }

    interface IBuffSkill
    {
        void Heal(int amount);
        void ApplyBuff();
    }

    public class Knight : IMeleeSkill
    {
        public void PhysicalAttack()
        {
            Debug.Log("Melee attack");
        }

        public void UseShield()
        {
            Debug.Log("use shield");
        }
    }

    public class Elf : IMeleeSkill, IMagicSkill
    {
        public void CastSpell(string spellName)
        {
            throw new System.NotImplementedException();
        }

        public void CheckMana()
        {
            throw new System.NotImplementedException();
        }

        public void PhysicalAttack()
        {
            throw new System.NotImplementedException();
        }

        public void UseShield()
        {
            throw new System.NotImplementedException();
        }
    }
}
