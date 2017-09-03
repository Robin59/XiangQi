using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class PieceClicked : UnityEvent<PieceBehaviour> { }

public abstract class PieceBehaviour : MonoBehaviour {    

    public int xPosition; // horizontal position on the chess board (from 0(a) to 8(i)) 
    public int yPosition; // vertical position on the chess board (from 0 to 9) 
    public bool redPiece;// True if it's a red piece, false if it's a black piece
    public bool pieceSelected; // true for the current selected piece, false for the other
    public PieceClicked pieceClicked = new PieceClicked();

    public virtual bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        return -1 < xNewPosition && xNewPosition < 9 && -1 < yNewPosition && xNewPosition < 10;
    }

    public void MoveTo(int xNewPosition, int yNewPosition)
    {        
        if (movement_Possible(xNewPosition, yNewPosition))
        {
            xPosition = xNewPosition;
            yPosition = yNewPosition;

            //change the transform in fonction of the new position
            char xPosition_in_Char = (char) ((int)'a' + xPosition);            
            string intersectionName = xPosition_in_Char.ToString()+(yPosition).ToString();
            Button intersection = GameObject.Find(intersectionName).GetComponent<Button>();
            transform.position = intersection.transform.position;            
            
            }
    }

    // Use this for initialization
    protected void Start () {
        MoveTo(xPosition, yPosition);
    }
	
	// Update is called once per frame
	protected void Update () {
        Image image = GetComponentInParent<Image>();
        if (pieceSelected) image.color = Color.white;
        else image.color = Color.grey;
    }   

    public void OnClicked()
    {
        pieceClicked.Invoke(this);
        //pieceSelected =!pieceSelected;       
    }

    /*public void OnPieceUnselected()
    {
        pieceSelected = false;
    }*/
   
}
