using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour
{

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		//create a local variable. vector 3 (a struct of 3 no.) (f required as a float)
		// this.transform.position.y  keeps the original pos of y.
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		print ("Hello, Ball.");
		
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 8;
		// paddlePos.x = mousePosInBlocks; becomes
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.65f, 7.35f);
		
		//Keyword 'this' refer to the current object (in this case the Paddle)
		//Keyword this. does not need to be used here, transform function can (lol)function without it in this casez
		this.transform.position = paddlePos;
		
		
	}
}






//StartPoint = ScreenToWorldPoint(FingerStart);
//EndPoint = ScreenToWorldPoint(FingerEnd);
//Range = EndPoint - StartPoint;
