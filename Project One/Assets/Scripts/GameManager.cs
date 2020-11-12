using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public void Restart()
	{
		Invoke("EndGame", 1f);
	}

	public void LevelDelay()

	{
		Invoke("LoadLevel", 1f);
	}

	public void EndGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		CoinScript.coinValue = 0;
	}

	public void LoadLevel()
	{
		SceneManager.LoadScene(0);
	}
}
