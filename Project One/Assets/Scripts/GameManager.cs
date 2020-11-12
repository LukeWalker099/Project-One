using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public void Restart()
	{
		Invoke("EndGame", 1f);
		Invoke("LoadLevel1", 1f);
	}
	public void EndGame()
	{
		SceneManager.LoadScene(0);
		CoinScript.coinValue = 0;
	}

	public void LoadLevel()

	{
		SceneManager.LoadScene(1);
	}
}
