using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {

	public enum Player
	{
	
		player_1 = 1,
		player_2 = 2
	}

	public float paddleSpeed;
	public Player player;
	private Vector3 moveDirection;
	private float camHeight;
	// Use this for initialization
	//bool p1up,p1down,p2up,p2down;
	void Start () 
	{
		//p1up = p1down = p2up = p2down = false;
		moveDirection = new Vector3();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(player == Player.player_1)
		{
			if(Input.GetKey (KeyCode.W))
			{
				moveDirection.y = paddleSpeed;
			}
			else if(Input.GetKey (KeyCode.S))
			{
				moveDirection.y =- paddleSpeed;
			}else
			{
				moveDirection.y = 0;
			}
		}
		else if(player == Player.player_2)
		{
			if(Input.GetKey (KeyCode.UpArrow))
			{
				moveDirection.y = paddleSpeed;
			}
			else if(Input.GetKey (KeyCode.DownArrow))
			{
				moveDirection.y = -paddleSpeed;
			}
			else
			{
				moveDirection.y = 0;
			}
		}
		if ((transform.position + (moveDirection * Time.deltaTime)).y < Camera.main.orthographicSize - 0.75f && (transform.position + (moveDirection * Time.deltaTime)).y > -Camera.main.orthographicSize+0.75)
		transform.Translate(moveDirection*Time.deltaTime);
	
	}
}
