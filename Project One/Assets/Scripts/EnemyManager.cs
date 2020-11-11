using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	[Header("Game Objects")]
	[SerializeField]
	private Player player;

	[Header("Spawn Point")]
	private float xSpawn = -4.50f;
	private float ySpawn = -3.60f;

	private void OnTriggerEnter2D(Collider2D other)

	{
		// Damage Player 

		if (other.gameObject.CompareTag("Player"))
		{
			if (player.currentHealth >= 3)
			{
				player.currentHealth -= 1;
			}
			else if (player.currentHealth >= 2)
			{
				player.currentHealth -= 1;
			}
			else if (player.currentHealth >= 1)
			{
				player.currentHealth -= 1;
				player.transform.position = new Vector2(xSpawn, ySpawn);
				player.currentHealth = 3;
			}
		}
	}

}
