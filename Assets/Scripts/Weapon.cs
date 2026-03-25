using UnityEngine;

public class Weapon
{
    [SerializeField] private int damage = 10;
    [SerializeField] private int ammo = 30;

    public void Shoot(Enemy target)
    {
        if (target == null || ammo <= 0)
            return;
        if (ammo > 0)
        {
            target.TakeDamage(damage);
            ammo--;
        }
    }
}
