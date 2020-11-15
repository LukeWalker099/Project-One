using UnityEngine;

public class Platform : MonoBehaviour
{
	[SerializeField]
	private bool moveRight;
	public Rigidbody2D rb;
	public float movSpeed;

	private void Update()
	
	{
		if (moveRight)
		
		{
			transform.Translate(Vector3.left * movSpeed * Time.deltaTime);
		}
		else
		{
			transform.Translate(Vector3.right * movSpeed * Time.deltaTime);
		}
		
	}

	private void OnCollisionEnter2D(Collision2D other)

	{
		if (other.gameObject.CompareTag("Turn"))
		{
			moveRight = false;
		}
		else
		{
			moveRight = true;
		}
	}

}

