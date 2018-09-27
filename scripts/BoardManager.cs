using UnityEngine;
using System.Collections;
using System.IO;
// creating game board

public class Board : MonoBehaviour

{
	public enum Pieces { red, blue, Empty };

	int width = 5;
	int height = 5; 
	public GameObject obj, horizontal_red ,horizontal_blue,vertical_blue,vertical_red;
	public struct box {
		public GameObject top, down,left,right;
		public int hited;
		box(GameObject t,GameObject d ,GameObject l,GameObject r)
		{
			top=t;
			down=d;
			left=l;
			right=r;
			hited=0;

		}
	}


	public box[,] board;
	public Board(){
		board=new box[width,height]; // a two-dimensional array representing the game board
	}

	//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	//+                   get the chosen piece                                                       +
	//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	public GameObject GetPiece()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit = new RaycastHit ();
			if (Physics.Raycast (ray.origin, ray.direction,out hit, -10))
				return hit.transform.gameObject;
		}
	
		return null;

	}
	//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
	//+                   searching for piece in the matrix                                                   +
	//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

	public void searchPiece(GameObject x){
		for (int i = 0; i < board.GetLength (0); i++) {
			for (int j = 0; j < board.GetLength (0); j++)
				if (board [i, j].top == x || board [i, j].down == x || board [i, j].left == x || board [i, j].right == x)
					board [i, j].hited += 1;
		}
	}


	// possible moves 




	//**********************************************************************************************
	public void MakeMove_hor(int position, Pieces piece)
	{

		GameObject p = GetPiece();

		searchPiece (p);
		if( piece == Pieces.red)
			Instantiate (horizontal_red, p.transform.position, Quaternion.identity);
		else
			Instantiate (horizontal_blue, p.transform.position, Quaternion.identity);
	}



	public void MakeMove_ver(int position, Pieces piece)
	{

		GameObject p = GetPiece();

		searchPiece (p);
		if( piece == Pieces.red)
			Instantiate (vertical_red, p.transform.position, Quaternion.identity);
		else
			Instantiate (vertical_blue, p.transform.position, Quaternion.identity);
	}

	}


