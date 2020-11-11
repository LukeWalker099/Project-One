using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public void Restart()
	{
		Invoke("EndGame", 1f);
	}
	public void EndGame()
	{
		SceneManager.LoadScene(0);
	}
}
