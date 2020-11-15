using System.Transactions;
using UnityEngine;

public class Player : MonoBehaviour
{
	[Header("Game Objects")]
	public GameManager gameManager;
	public EnemyManager enemyManager;
	public SpriteRenderer sprite;
	private Animator charJump;

	[Header("Coin Collectable")]
	public GameObject[] coin1;

	[Header("Movement")]
	public Rigidbody2D rb;
	public float movSpeed;
	public float jumpHeight;
	[SerializeField]
	private bool isGrounded;

	[Header("Health")]
	public int currentHealth;
	public int maxHealth;

	private void Start()

	{
		charJump = gameObject.GetComponent<Animator>();
	}

	private void Update()

	{
		// Move Left and Right

		if (Input.GetKey(KeyCode.A) ||Input.GetKey(KeyCode.LeftArrow)) 
		{
			sprite.flipX = true;
			transform.Translate(Vector2.left * movSpeed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			sprite.flipX = false;
			transform.Translate(Vector2.right * movSpeed * Time.deltaTime);
		}

		// Jump 

		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			charJump.SetBool("isJumping", true);
			rb.AddForce(Vector2.up * jumpHeight);
		}
		else
		{
			charJump.SetBool("isJumping", false);
		}

		// Player Health

		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	}


	private void OnTriggerEnter2D(Collider2D other)

	{
		// Check if Player Collects Coin

		if (other.gameObject.CompareTag("Coin"))
		{
			Destroy(other.gameObject);
			CoinScript.coinValue += 1;
		}

		// Check if Player Enters Water

		if (other.gameObject.CompareTag("Water"))
		{
			gameManager.Restart();
			Destroy(enemyManager.heart1);
			Destroy(enemyManager.heart2);
			Destroy(enemyManager.heart3);
		}


	}

	private void OnCollisionStay2D(Collision2D other)

	{
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
