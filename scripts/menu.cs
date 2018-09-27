using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Play  () {
		SceneManager.LoadScene("Xx", LoadSceneMode.Additive);
	}
	void quit()
	{
		Application.Quit(); 
	}

}
