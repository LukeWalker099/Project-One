using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
	[Header("Hearts")]
	public RawImage heart1;
	public RawImage heart2;
	public RawImage heart3;

	[Header("Game Objects")]
	[SerializeField]
	private Player player;
	[SerializeField]
	private GameManager GM;

	//[Header("Player Spawn Point")]
	//private float xSpawn = -4.50f;
	//private float ySpawn = -3.60f;

	private void OnTriggerEnter2D(Collider2D other)

	{
		// Damage Player 

		if (other.gameObject.CompareTag("Player"))
		{
			if (player.currentHealth >= 3)
			{
				player.currentHealth -= 1;
				Destroy(heart3);
			}
			else if (player.currentHealth >= 2)
			{
				player.currentHealth -= 1;
				Destroy(heart2);
			}
			else if (player.currentHealth >= 1)
			{
				player.currentHealth -= 1;
				player.movSpeed = 0;
				player.jumpHeight = 0;
				Destroy(heart1);
				GM.Restart();
				//player.transform.position = new Vector2(xSpawn, ySpawn);
			}
		}
	}
}
