using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onhit_ver : MonoBehaviour {

	public GameObject Camera;
	public game Script; 
	//public BoardManager s;
	void Awake()
	{
		Script = Camera.GetComponent<game> ();

	}
	void OnMouseDown()
	{
		Script.play_ver(this.gameObject);
	}

}
