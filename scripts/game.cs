using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{

	public GameObject croix_rouge, croix_bleu, vertical_bleu, horizental_bleu, vertical_rouge, horizental_rouge, init;

	public enum couleur
	{
		rouge,
		bleu
	}

	public couleur tour;
	public int n = 21, m = 21;
	private Vector3[] position = new Vector3[40];
	Vector3 pos_croix, pos_croix2;
	public GameObject[] isplay = new GameObject[40];


	public Text player1ScoreText;
	public Text player2ScoreText;

	public Text winner1;
	public Text winner2;

	private int scorePlayer1 = 0;
	private int scorePlayer2 = 0;




	public int showWinner ()
	{
		if (scorePlayer1 > scorePlayer2)
			return scorePlayer1;
		return scorePlayer2;
	}

	/*public void addPoints (int score, Text scoreText, string player)
	{
		score = score + 10;
		scoreText.text = player + score; 
	}*/

	//***********************************//
	//***********************************//
	//                 START
	//***********************************//
	void Start ()
	{ 

		isplay = GameObject.FindGameObjectsWithTag ("isplay");
		for (int c = 0; c < isplay.Length; c++) {
			remplir_tab (isplay [c]);
		}
	}

	//remplissage de tableau par les positions des elements joués
	public void remplir_tab (GameObject o)
	{
		Vector3 p = o.transform.position;
		position [n] = p;
		n++;
		//Debug.Log (n);
	}



	//instanter une ligne horizontal
	//*************************************************************************************************************

	public void creer_horizental (GameObject objet)
	{ 

		if ((tour == couleur.rouge)) {

			if (!objet.CompareTag ("isplay")) { 
				Instantiate (horizental_rouge, objet.transform.position, Quaternion.identity);

			}
			if (verif_complete_box(objet,0.5f,-0.5f,-0.5f,-0.5f,0,-1f) && verif_complete_box(objet,0,1f,0.5f,0.5f,-0.5f,0.5f)) {

				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y - 0.5f;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);

				pos_croix2.x = objet.transform.position.x;
				pos_croix2.y = objet.transform.position.y + 0.5f;
				Instantiate (croix_rouge, pos_croix2, Quaternion.identity);

				scorePlayer1 = scorePlayer1 + 20;
				player1ScoreText.text = "Red "+ scorePlayer1; 

			} else if (verif_complete_box(objet,0.5f,-0.5f,-0.5f,-0.5f,0,-1f)) {
				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y - 0.5f;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);

				scorePlayer1 = scorePlayer1 + 10;
				player1ScoreText.text = "Red "+ scorePlayer1;
			} else if (verif_complete_box(objet,0,1f,0.5f,0.5f,-0.5f,0.5f)) {

				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y + 0.5f;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);

				scorePlayer1 = scorePlayer1 + 10;
				player1ScoreText.text = "Red "+ scorePlayer1;
			} 

			tour = couleur.bleu;

		} else {


			if (!objet.CompareTag ("isplay")) { 
				Instantiate (horizental_bleu, objet.transform.position, Quaternion.identity);
			}
			if (verif_complete_box(objet,0,1f,0.5f,0.5f,-0.5f,0.5f) && verif_complete_box(objet,0.5f,-0.5f,-0.5f,-0.5f,0,-1f)) {

				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y - 0.5f;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);


				pos_croix2.x = objet.transform.position.x;
				pos_croix2.y = objet.transform.position.y + 0.5f;
				Instantiate (croix_bleu, pos_croix2, Quaternion.identity);
				scorePlayer2 = scorePlayer2 + 20;
				player2ScoreText.text = "Blue "+ scorePlayer2;

			}

			else if (verif_complete_box(objet,0.5f,-0.5f,-0.5f,-0.5f,0,-1f)) {
				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y - 0.5f;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);

				scorePlayer2 = scorePlayer2 + 10;
				player2ScoreText.text = "Blue "+ scorePlayer2;

			}

			else if (verif_complete_box(objet,0,1f,0.5f,0.5f,-0.5f,0.5f)) {

				pos_croix.x = objet.transform.position.x;
				pos_croix.y = objet.transform.position.y + 0.5f;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);
				scorePlayer2 = scorePlayer2 + 10;
				player2ScoreText.text = "Blue "+ scorePlayer2;

			}

			tour = couleur.rouge;

		}
		Destroy (objet.gameObject);

	}



	//instanter une ligne vertical
	//*************************************************************************************************************************
	public void creer_vertical (GameObject objet)
	{

		if (tour == couleur.bleu) {

			if (!objet.CompareTag ("isplay"))
			{
				Instantiate (vertical_bleu, objet.transform.position, Quaternion.identity);
			}  

			if (verif_complete_box(objet,-0.5f,0.5f,-1f,0,-0.5f,-0.5f) && verif_complete_box(objet,1f,0,0.5f,0.5f,0.5f,-0.5f)) 
			{

				pos_croix.x = objet.transform.position.x + 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);


				pos_croix2.x = objet.transform.position.x - 0.5f;
				pos_croix2.y = objet.transform.position.y;
				Instantiate (croix_bleu, pos_croix2, Quaternion.identity);

				scorePlayer2 = scorePlayer2 + 20;
				player2ScoreText.text = "Blue "+ scorePlayer2; 
			}
			else if (verif_complete_box(objet,-0.5f,0.5f,-1f,0,-0.5f,-0.5f) )
			{

				pos_croix.x = objet.transform.position.x - 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);
				scorePlayer2 = scorePlayer2 + 10;
				player2ScoreText.text = "Blue "+ scorePlayer2; 

			}
			else if (verif_complete_box(objet,1f,0,0.5f,0.5f,0.5f,-0.5f))
			{	
				pos_croix.x = objet.transform.position.x + 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_bleu, pos_croix, Quaternion.identity);
				scorePlayer2 = scorePlayer2 + 10;
				player2ScoreText.text = "Blue "+ scorePlayer2; 
			}


			tour = couleur.rouge;
		} 
		else {

			if (!objet.CompareTag ("isplay")) 
			{
				Instantiate (vertical_rouge, objet.transform.position, Quaternion.identity);

			}

			if (verif_complete_box(objet,-0.5f,0.5f,-1f,0,-0.5f,-0.5f) && verif_complete_box(objet,1f,0,0.5f,0.5f,0.5f,-0.5f))
			{
				pos_croix.x = objet.transform.position.x - 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);

				pos_croix2.x = objet.transform.position.x + 0.5f;
				pos_croix2.y = objet.transform.position.y;
				Instantiate (croix_rouge, pos_croix2, Quaternion.identity);

				scorePlayer1 = scorePlayer1 + 20;
				player1ScoreText.text = "Red "+ scorePlayer1;

				Debug.Log ("2 croix");
			} 
			else if (verif_complete_box(objet,-0.5f,0.5f,-1f,0,-0.5f,-0.5f)) 
			{
				pos_croix.x = objet.transform.position.x - 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);

				scorePlayer1 = scorePlayer1 + 10;
				player1ScoreText.text = "Red "+ scorePlayer1;
			}

			else if (verif_complete_box(objet,1f,0,0.5f,0.5f,0.5f,-0.5f))
			{

				pos_croix.x = objet.transform.position.x + 0.5f;
				pos_croix.y = objet.transform.position.y;
				Instantiate (croix_rouge, pos_croix, Quaternion.identity);
				scorePlayer1 = scorePlayer1 + 10;
				player1ScoreText.text = "Red "+ scorePlayer1;
			}

			tour = couleur.bleu;
		}

		Destroy (objet.gameObject);

	}

	//comparaison de deux vecteurs
	//********************************************************************************************************

	bool compare_vector (Vector3 v)
	{

		for (int c = 0; c < position.Length; c++) {
			if (v == position [c])
				return true;
		}
		return false;
	}

	bool verif_complete_box(GameObject o, float x1 ,float y1 ,float x2 ,float y2 ,float x3,float y3)
	{
		bool x,y,z;
		bool resultat = false;
		Vector3 coo_x, coo_y, coo_z, pos;
		pos = o.transform.position;
		coo_x = new Vector3 (pos.x + x1, pos.y + y1, 0);
		x = compare_vector (coo_x);
		coo_y = new Vector3 (pos.x + x2, pos.y + y2, 0);
		y = compare_vector (coo_y);
		coo_z = new Vector3 (pos.x + x3, pos.y + y3, 0);
		z = compare_vector (coo_z);
		if (x && z && y)
			resultat = true;

		return (false || resultat);


	}

	//--------------------------------------------------------------------------------------------------------
	//--------------------------------------------------------------------------------------------------------
	public void play_hor (GameObject o)
	{
		creer_horizental (o);
		this.gameObject.tag = "isplay";
		//Debug.Log (this.gameObject.tag);

		remplir_tab (o);


	}
	//--------------------------------------------------------------------------------------------------------
	//--------------------------------------------------------------------------------------------------------

	public void play_ver (GameObject o)
	{
		creer_vertical (o);
		this.gameObject.tag = "isplay";
		//Debug.Log (o);
		remplir_tab (o);

	}





}
