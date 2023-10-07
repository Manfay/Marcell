using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    [SerializeField] int health;

    void Start()
    {
        health = startHealth;
    }

    public void Damage(int damage)
    {
        if (health <= 0) return;

        health -= damage;

        if (health <= 0)
            Debug.Log("I'm dead");

        if (health < 0)
            health = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            startHealth = 10;
        }
    }
}

