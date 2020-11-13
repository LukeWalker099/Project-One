using UnityEngine;

public class CharAnim : MonoBehaviour
{
	public Animator charAnim;
	public bool isCharRight;


	private void Update()

	{
		if (Input.GetKey(KeyCode.D))
		{
			isCharRight = true;
		}
		else
		{
			isCharRight = false;
		}
	}


}
