using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[Header("Game Objects")]
    public GameObject wellDoneText;
    public GameObject nextLvlButton;
	public Player player;

	private void Start()

	{
		wellDoneText.SetActive(false);
		nextLvlButton.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		{
			player.movSpeed = 0;
			player.jumpHeight = 0;
			wellDoneText.SetActive(true);
			nextLvlButton.SetActive(true);
		}
	}
}
