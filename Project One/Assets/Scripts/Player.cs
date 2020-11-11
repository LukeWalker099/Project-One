using UnityEngine;

public class Player : MonoBehaviour
{
	[Header("Movement")]
	public Rigidbody2D rb;
	public float movSpeed;
	public float jumpHeight;
	[SerializeField]
	private bool isGrounded;

	private void Update()

	{
		// Move Left and Right

		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.Translate(Vector2.left * movSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector2.right * movSpeed * Time.deltaTime);
		}

		// Jump 

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(Vector2.up * jumpHeight);
		}
	}


	private void OnCollisionStay2D(Collision2D other)

	{
		// Check if Player is Grounded

		if (other.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}
}
