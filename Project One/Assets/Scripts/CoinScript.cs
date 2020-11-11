using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
	public static int coinValue;
	public Text coin;

	private void Start()
	{
		coin = gameObject.GetComponent<Text>();
	}

	public void Update()

	{
		coin.text = "Coins " + coinValue;
	}


}
