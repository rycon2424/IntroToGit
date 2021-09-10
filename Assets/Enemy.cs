using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public GameObject playerInstance;
    
    protected const float EnemySpeed = 5f;
    protected int enemyHealth = 100;

    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
