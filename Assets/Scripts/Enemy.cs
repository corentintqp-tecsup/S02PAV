using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Health health = new();

    public void TakeDamage(int damage)
    {
        if (IsDead())
            return;
        health.TakeDamage(damage);
    }

    void Update()
    {
        if (IsDead())
            Destroy(gameObject);
    }

    public bool IsDead()
    {
        return health.GetHealth() <= 0;
    }

}
