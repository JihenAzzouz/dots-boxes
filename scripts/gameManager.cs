/*-using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
	public List<GameObject> croix;
	
	public GameObject SelectedLine;
	public List<GameObject> lines;
	Vector3 mouseposition;
	float distance = 10f;
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < 16; i++) {

			lines [i].GetComponent<Renderer> ().enabled = false;
		}
		for (int i = 0; i < 13; i++) {
			croix [i].SetActive (false);
		
		}

	}
	//{-------------------------------------------------------------}
	//{        essay hiting something with the random thing         }
	//{-------------------------------------------------------------}

	int activBox (Ray r)
	{
		int z = 0;
		for (int i = 0; i < 100000; i++) {
			float x = r.origin.x; 
			float y = r.origin.y;
			Vector3 position = new Vector3 (Random.Range (x, x + 1), Random.Range (0, x + 1), r.origin.z);
			Ray r1 = Camera.main.ScreenPointToRay (position);
			RaycastHit hitinfo = new RaycastHit ();
			if (Physics.Raycast (r1.origin, r1.direction, out hitinfo, 10)) {

				print ("Hit something!");
				z++;
			}
		}
		return z;
	}


	//{-------------------------------------------------------------}
	//{        verifications of active sides Of  the box            }
	//{-------------------------------------------------------------}

	private bool verif(int x,int y,int z,string s,string s1)
	{
		if ((lines[x].GetComponent<Renderer> ().enabled == true) && (lines [y].GetComponent<Renderer> ().enabled == true) &&
			(lines [z].GetComponent<Renderer> ().enabled == true) && (s == s1) )
			return true;
		return false;
	}


	private bool verif1(int x , string s,string s1)
	{
		if((lines [x].GetComponent<Renderer> ().enabled == true) && (s == s1))
		  return true;
	  return false;
	}

	private bool verif2(string s,string s1)
	{
		if(s == s1)
			return true;
		return false;
	}

	void Update ()
	{
		mouseposition = Input.mousePosition;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		GameObject x;
		string y;
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hitinfo = new RaycastHit ();
			if (Physics.Raycast (ray.origin, ray.direction, out hitinfo, 10))
			{
				print ("Hit something!");
				Debug.Log (ray);
					
				Debug.Log ("Hit " + hitinfo.transform.gameObject.name);
				y = hitinfo.transform.gameObject.name;
					
				print (y);
				x = hitinfo.transform.gameObject;
				Debug.Log (x);

				//Debug.Log (v);
				x.GetComponent<Renderer> ().enabled = true;

				switch (y) {
				case("Line-7-L (34)"):
				//Debug.Log (x);
		        croix [0].SetActive (true);
					
					break;
				  
				case("Line-7-L (45)"):
					x = hitinfo.transform.gameObject;
					Debug.Log (x);

		
					croix [1].SetActive (true);
					break;
				case("Line-7-L (39)"):
					
					Debug.Log (x);

				
					croix [2].SetActive (true);
					break;
				case("Line-7-L (38)"):

					Debug.Log (x);

		
					croix [3].SetActive (true);
					break;
				} 

			
				if (verif1(6,y,"Line-7-L (31)")||verif1(2,y,"Line-7-L (46)")) 
					croix [4].SetActive (true);
				
				if (verif1(13,y,"Line-7-L (33)")||verif1(4,y,"Line-7-L (42)")) 
					croix [6].SetActive (true);
				
				if (verif1(3,y,"Line-7-L (40)")||verif1(11,y,"Line-7-L (32)")) 
					croix [12].SetActive (true);
				
				if (verif1(14,y,"Line-7-L (37)")||verif1(8,y,"Line-7-L (43)")) 
					croix [10].SetActive (true);
			
				if (verif(4,12,3,y,"Line-7-L (38)")||verif(9,12,3,y,"Line-7-L (33)")||verif(9,12,4,y,"Line-7-L (32)")||verif(9,3,4,y,"Line-7-L (41)"))
					croix [9].SetActive (true);

				if (verif(14,10,7,y,"Line-7-L (40)")||verif(14,10,11,y,"Line-7-L (36)")||verif(11,10,7,y,"Line-7-L (43)")||verif(11,7,14,y,"Line-7-L (39)"))
					croix [11].SetActive (true);
				
				if (verif(0,6,1,y,"Line-7-L (37)")||verif(0,6,8,y,"Line-7-L (35)")||verif(0,1,8,y,"Line-7-L (46)")||verif(6,1,8,y,"Line-7-L (34)"))
					croix [7].SetActive (true);
				
				if (verif(2,15,13,y,"Line-7-L (44)")||verif(2,15,5,y,"Line-7-L (42)")||verif(15,13,5,y,"Line-7-L (31)")||verif(13,5,2,y,"Line-7-L (45)"))
					croix [5].SetActive (true);
				
				if (verif(1,7,12,y,"Line-7-L (44)")||verif(5,7,12,y,"Line-7-L (35)")||verif(5,1,12,y,"Line-7-L (36)")||verif(5,1,7,y,"Line-7-L (41)"))
					croix [8].SetActive (true);
			}	
		}

	}
}
*/