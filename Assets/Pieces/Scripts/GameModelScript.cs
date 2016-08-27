using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class GameModelScript : MonoBehaviour {

    GameObject redPlayer;
    GameObject blackPlayer;
    GameObject PlayerCurrentlyPlaying;
    PieceBehaviour CurrentPieceSelected;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void EndTurn()
    {
        //change playerTurn
    }

    public void OnPositionClicked(byte x, byte y)
    {        
        Debug.Log("Position clicked: "+x.ToString()+" "+y.ToString());
    }

    public void OnPieceClicked(PieceBehaviour pieceBehaviour)
    {       
        Debug.Log("Piece clicked: "+pieceBehaviour.xPosition+" "+pieceBehaviour.yPosition);
        //CurrentPieceSelected= (pieceBehaviour.pieceSelected) ? pieceBehaviour : null; // more complicated than that 
    }
}
