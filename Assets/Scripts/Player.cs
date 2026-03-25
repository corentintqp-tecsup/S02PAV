using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Enemy enemy;
    [SerializeField] private Health health = new();
    [SerializeField] private Weapon weapon = new();

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack(enemy);
        }
    }

    public void Attack(Enemy target)
    {
        weapon.Shoot(target);
    }

    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }
}
