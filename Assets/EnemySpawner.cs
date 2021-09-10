using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    private void Start()
    {
        // Spawn some enemies
        for( int i = 0; i < 10; ++i ) {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3(Random.Range(-100,100), 0, Random.Range(-100,100));
        }
    }
}
