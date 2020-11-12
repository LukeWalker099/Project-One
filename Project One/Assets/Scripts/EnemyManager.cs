using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
	[Header("Hearts")]
	public RawImage heart1;
	public RawImage heart2;
	public RawImage heart3;

	[Header("Game Objects")]
	public GameObject restartButton;
	public GameObject restartText;
	[SerializeField]
	private Player player;
	[SerializeField]
	private GameManager GM;

	//[Header("Player Spawn Point")]
	//private float xSpawn = -4.50f;
	//private float ySpawn = -3.60f;


	private void Start()

	{
		restartButton.SetActive(false);
		restartText.SetActive(false);
	}

	private void OnCollisionEnter2D(Collision2D other)

	{
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
				restartButton.SetActive(true);
				restartText.SetActive(true);
				//player.transform.position = new Vector2(xSpawn, ySpawn);
			}
		}
	}

	private void OnCollisionExit2D(Collision2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Avoided!");
		}
	}

}
