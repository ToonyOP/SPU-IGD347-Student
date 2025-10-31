using Theory.Week10;
using UnityEngine;


public class UseWeapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("---- Bad Calculate Damage ----");
        Weapon sword = new Weapon(WeaponType.Knife, 10);
        //Debug.Log($"Sword Damage: {GoodCalculateDamage((IBonusWeapon)Knife)}"); // Output: Sword Damage: 15

    }
    public int GoodCalculateDamage(IBonusWeapon weapon)
    {
        return weapon.GetDamage();
    }

    public int BadCalculateDamage(Weapon weapon)
    {
        int totalDamage = weapon.BaseDamage;
        if (weapon.Type == WeaponType.Knife)
        {
            totalDamage += 5; // โบนัสดาบ
        }
        else if (weapon.Type == WeaponType.Bow)
        {
            totalDamage += 3; // โบนัสธนู
        }
        else if (weapon.Type == WeaponType.Gun)
        {
            totalDamage += 10; // โบนัสปืน
        }
        // ถ้าเพิ่ม WeaponType.Axe ต้องมาเพิ่ม else if ตรงนี้
        else if (weapon.Type == WeaponType.Axe)
        {
            totalDamage += 15; 
        }
        return totalDamage;
    }
    
}
