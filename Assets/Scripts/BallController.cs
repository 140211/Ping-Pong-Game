using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BallController : MonoBehaviour {

	public float ballSpeed;
	public float force;
	//Scores
	public Text Scores;
	public Text Scores2;
	private int p1countScores,p2countScores;

	//private Vector3 moveDirection;

	private Rigidbody2D ballRigidBody2D;
	// Use this for initialization
	void Start () {
		//moveDirection = new Vector3();
		ballRigidBody2D = GetComponent<Rigidbody2D>();
		ballRigidBody2D.AddForce (new Vector2 (Random.Range(-.5f,.100f),Random.Range(-.5f,.5f)).normalized*force ,ForceMode2D.Impulse);

		//Scores
		p1countScores = 0;
		Scores.text = p1countScores.ToString ();

		p2countScores = 0;
		Scores2.text = p2countScores.ToString ();

	}

	// Update is called once per frame
	void Update () {


	}
	void FixedUpdate()
	{
		ballRigidBody2D.velocity = ballRigidBody2D.velocity.normalized * ballSpeed;

	}
	void OnCollisionEnter(Collision colr){

		if (colr.gameObject.tag == "p") {
			//colr.gameObject.SetActive (false);
			p1countScores += 1;
			Scores.text = p1countScores.ToString ();
		}
		if (colr.gameObject.tag == "pp") {
			//colr.gameObject.SetActive (false);
			p2countScores += 1;
			Scores2.text = p2countScores.ToString ();
		}
	}
}
