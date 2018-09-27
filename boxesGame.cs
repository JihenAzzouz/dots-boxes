/*using System;
using System.Collections;
using UnityEngine;
using System.IO;

public class boxesGame : MonoBehaviour
	{
	enum players{player1, player2};
	Board board;
	players currPlayer = players.player1;
	 List <Move> moves ;
	bool gameOver = false;
	public boxesGame ():this(Board.Pieces.red,Board.Pieces.red)
		{
		 	
		}
	public boxesGame(Board.Pieces p1P,Board.Pieces p2P)
	{
		this.p1P = p1P;
		this.p2P = p2P;
		board = new Board ();
		moves =new List<Move>();

	}
	public void MakeMove_hor(Move m,players p)
	{
		board.MakeMove_hor (m.position, m.piece);
		moves.Push (m);
		SwapTurns ();
	}
	public void MakeMove_ver(Move m,players p)
	{
		board.MakeMove_ver (m.position, m.piece);
		moves.Push (m);
		SwapTurns ();
	}

	}
*/

