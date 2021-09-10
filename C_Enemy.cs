using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Enemy : MonoBehaviour
{
	C_Enemy(int health) 
	{

		GameObject enemy = GameObject.Instantiate(enemyPrefab);
		enemy.transform.position = new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100));
		enemies.Add(enemy);
		enemyHealth.Add(ENEMY_HEALTH);


	}

	void movetoplayer(float playerPos) 
	{

		//move to player 
		//enemies[i].transform.Translate((playerInstance.transform.position - enemies[i].transform.position).normalized * Time.deltaTime * ENEMY_SPEED);
	}

}
