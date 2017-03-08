using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour
{
	
	public PaddleScript paddle;
	
	//this. because we are in the context of Ball
	private  Vector3 paddleToBallVector;
	// Use this for initialization
	void Start ()
	{
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print ("paddleToBallVector");
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.transform.position = paddle.transform.position + paddleToBallVector;
	}
}


//void LaunchBallFromPaddle(){
//	float direction = (float)(Random.Range(-2f, 2f));               
//	this.rigidbody2D.velocity = new Vector2 (direction, momentum);   
//	isBallOnPaddle = false;                                    
//}