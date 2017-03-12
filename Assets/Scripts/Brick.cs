using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;

	// Use this for initialization
	void Start ()
	{
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	

	  /* @3:30~4:00min in lecture 80 sect 5*/
	void OnCollisionEnter2D  (Collision2D col) {timesHit++;/*same as timesHit+1;*/}
}
