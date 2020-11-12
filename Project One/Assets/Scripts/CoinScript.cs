using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
	public static int coinValue;
	public Text coin;


	public void Update()

	{
		coin.text = "" + coinValue;
	}


}
