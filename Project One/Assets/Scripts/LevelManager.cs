using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[Header("Game Objects")]
	public GameObject wellDoneText;
	public GameObject endCoinText;
    public GameObject nextLvlButton;
	public GameObject coins;
	public GameObject coinsEnd;
	public GameObject origCoinImg;
	public Player player;

	private void Start()

	{
		coinsEnd.SetActive(false);
		wellDoneText.SetActive(false);
		nextLvlButton.SetActive(false);
		endCoinText.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		{
			coins.SetActive(false);
			player.enabled = false;
			origCoinImg.SetActive(false);
			wellDoneText.SetActive(true);
			nextLvlButton.SetActive(true);
			endCoinText.SetActive(true);
			coinsEnd.SetActive(true);
		}
	}
}
