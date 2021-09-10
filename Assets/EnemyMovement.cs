using UnityEngine;

public class EnemyMovement : Enemy
{
    // Update enemies
    private void Update()
    {
        transform.Translate((playerInstance.transform.position - transform.position).normalized * Time.deltaTime * EnemySpeed);
    }
}
