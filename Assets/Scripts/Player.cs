using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Enemy enemy;
    [SerializeField] private Health health = new();
    [SerializeField] private Weapon weapon = new();

    private InputSystem_Actions inputs;


    void Awake()
    {
        inputs = new();
    }

    private void OnEnable()
    {
        inputs.Player.Attack.performed += OnAttack;
        inputs.Player.Enable();
    }

    private void OnDisable()
    {
        inputs.Player.Attack.performed -= OnAttack;
        inputs.Player.Disable();
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        Attack(enemy);
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
