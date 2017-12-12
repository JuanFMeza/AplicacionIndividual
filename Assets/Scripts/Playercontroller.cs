using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIdGround;
	private bool grounded;

	private bool doubleJumped;

	private Animator anim;


	void Start () {
		 anim = GetComponent<Animator> ();
	}
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIdGround);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode. Space)) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 (0, jumpHeight);
		}

		 anim.SetBool ("Grounded", grounded);

		if (Input.GetKey (KeyCode.D)) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		}
		if (Input.GetKey (KeyCode.A)) {

			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
		}
		 anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D>().velocity.x));
	}

	void OnTriggerEnter (Collider obj)
	{

		
		if (obj.gameObject.tag == "enlace") {
			
			if ( Application.loadedLevelName  == "Main"  ){
				SceneManager.LoadScene (  "scena2"  );
			} else {
				SceneManager.LoadScene ( "Main" );
			}
		}
	}
}

