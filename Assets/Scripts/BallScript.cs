using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
	
	public PaddleScript paddle;
	private bool hasGameStarted = false;
	
	// this. because we are in the context of Ball. Ball.cs == this.
	// stores the distance between[them/the methods] across the entire class Section 5 Lect 77
	private  Vector3 paddleToBallVector;
	
	
	// Use this for initialization
	void Start ()
	{
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if  	(!hasGameStarted) 	{this.transform.position = paddle.transform.position + paddleToBallVector;
									if (Input.GetMouseButtonDown(0)) 	{print ("Button clicked, ball launched");
																					hasGameStarted = true;
																					this.rigidbody2D.velocity = new Vector2 (2f,10f);
																					}
									}
	}
}


//void LaunchBallFromPaddle(){
//	float direction = (float)(Random.Range(-2f, 2f));               
//	this.rigidbody2D.velocity = new Vector2 (direction, momentum);   
//	isBallOnPaddle = false;                                    
//}