using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health health = new();

    public void TakeDamage(int damage)
    {
        if (IsDead())
            return;
        health.TakeDamage(damage);
        Debug.Log($"Enemy took {damage} damage, remaining health: {health.GetHealth()}");
    }

    void Update()
    {
        if (IsDead())
        {
            Debug.Log("Enemy is dead!");
            Destroy(gameObject);
        }
    }

    public bool IsDead()
    {
        return health.GetHealth() <= 0;
    }

}
