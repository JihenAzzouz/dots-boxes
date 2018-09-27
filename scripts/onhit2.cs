using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onhit2 : MonoBehaviour {

	public GameObject Camera;
	public game script; 
	//public BoardManager s; 
	void Awake()
	{
		script = Camera.GetComponent<game> ();

	}
	void OnMouseDown()
	{
		script.play_hor(this.gameObject);
	}


}
