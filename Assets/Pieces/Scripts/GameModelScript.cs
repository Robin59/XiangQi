using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class GameModelScript : MonoBehaviour {

    GameObject redPlayer;
    GameObject blackPlayer;
    bool redPlayerTurn;//true if it's red player's turn , false if it's black's turn
    PieceBehaviour currentPieceSelected;
    
    void Start () {
        redPlayerTurn = true;
    }
		
	void Update () {
	
	}

    public void EndTurn()
    {
        currentPieceSelected.pieceSelected = false;
        currentPieceSelected = null;
        redPlayerTurn = !redPlayerTurn;
    }

    public void OnPositionClicked(byte x, byte y)
    {        
        Debug.Log("Position clicked: "+x.ToString()+" "+y.ToString());
        if (currentPieceSelected != null)
        {
            if (currentPieceSelected.movement_Possible(x,y))
            {
                currentPieceSelected.MoveTo(x, y);                
                EndTurn();
            }
        }
    }

    public void OnPieceClicked(PieceBehaviour pieceBehaviour)
    {       
        Debug.Log("Piece clicked: "+pieceBehaviour.xPosition+" "+pieceBehaviour.yPosition);
        if (pieceBehaviour.redPiece == redPlayerTurn)
        {           
            if (pieceBehaviour.pieceSelected)
            {
                currentPieceSelected.pieceSelected = false;
                currentPieceSelected = null;
            }else
            {
                if (currentPieceSelected!=null) currentPieceSelected.pieceSelected = false;
                pieceBehaviour.pieceSelected = true;
                currentPieceSelected = pieceBehaviour;                
            }            
        }
    }
}
