using UnityEngine;

public class Troll : Enemy
{
    private float _healChance = 0.5f; // 20% kans om aan te vallen te ontwijken

    private void Start()
    {
        gameObject.name = "Troll";
        health = 300;
    }
    public override void TakeDamage(float damage)
    {
        if (Random.value < _healChance)
        {
            Debug.Log("Troll heeft meer Hp");
            health += 25;
            return;
        }

        base.TakeDamage(damage); // Gewone damage berekening
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"de troll slaat {target.name}");
    }
}