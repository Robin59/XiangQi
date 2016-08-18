using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public abstract class PieceBehaviour : MonoBehaviour {

    public int xPosition; // horizontal position on the chess board (from 0(a) to 8(i)) 
    public int yPosition; // vertical position on the chess board (from 0 to 9) 
    public GameObject owner;// The player that own the piece

    public virtual bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        return -1 < xNewPosition && xNewPosition < 9 && -1 < yNewPosition && xNewPosition < 10;
    }

    public void moveTo(int xNewPosition, int yNewPosition)
    {        
        if (movement_Possible(xNewPosition, yNewPosition))
        {
            xPosition = xNewPosition;
            yPosition = yNewPosition;

            //change the transform in fonction of the new position
            char xPosition_in_Char = (char) ((int)'a' + xPosition);            
            string intersectionName = xPosition_in_Char.ToString()+(yPosition).ToString();             
            Image intersection = GameObject.Find(intersectionName).GetComponent<Image>();
            transform.position = intersection.transform.position;            

            //end player turn
            }
    }

    // Use this for initialization
    protected void Start () {
        moveTo(xPosition, yPosition);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
