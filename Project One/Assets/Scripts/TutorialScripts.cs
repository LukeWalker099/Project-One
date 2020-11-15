using UnityEngine;

public class TutorialScripts : MonoBehaviour
{
	[Header("Game Objects")]
    public GameObject tutorialText1;


	private void Start()
	
	{
		tutorialText1.SetActive(false);
	}

	private void OnTriggerEnter2D(Collider2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		
		{
			tutorialText1.SetActive(true);
		}
	}

	private void OnTriggerExit2D(Collider2D other)

	{
		if (other.gameObject.CompareTag("Player"))
		
		{
			tutorialText1.SetActive(false);
		}
	}

}
