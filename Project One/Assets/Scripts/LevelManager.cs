using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[Header("Game Objects")]
	public GameObject wellDoneText;
    public GameObject nextLvlButton;
	public GameObject coins;
	public GameObject coinsEnd;
	public Player player;

	private void Start()

	{
		coinsEnd.SetActive(false);
		wellDoneText.SetActive(false);
		nextLvlButton.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		{
			coins.SetActive(false);
			player.movSpeed = 0;
			player.jumpHeight = 0;
			wellDoneText.SetActive(true);
			nextLvlButton.SetActive(true);
			coinsEnd.SetActive(true);
		}
	}
}
