﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;

	// Use this for initialization
	void Start ()
	{
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	

	  /* @3:30~4:00min in lecture 80 sect 5*/
	void OnCollisionEnter2D  (Collision2D col)
	{
		timesHit++;/*same as timesHit+1;*/
		if  (timesHit >= maxHits)		{Destroy(gameObject);}
		
	}
	// TODO Remove this method once we can actually win
	
	void SimulateWin()
	{
		levelManager.LoadNextLevel();
		
	}
}




/* make 4 prefabs, then int randomNum = Random.Range(1,4) 
then make a switch statement if randomNum == 1 
then instantiate prefab 1 if 2 the 2nd and so */



