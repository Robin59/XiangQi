using System;
using UnityEngine;

public class XiangBehaviour : PieceBehaviour{

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        bool diagonalMov = (Math.Abs(yPosition - yNewPosition) == 2) && (Math.Abs(xPosition - xNewPosition) == 2);

        bool riverNotCrossed = ((redPiece) && (yNewPosition < 5)) || ((!redPiece) && (yNewPosition > 5));

        int yIntermediate = yNewPosition + ((yPosition-yNewPosition)/2);
        int xIntermediate = xNewPosition + ((xPosition - xNewPosition) / 2);            

        return diagonalMov && riverNotCrossed && noPiecesBlockingMvt(xIntermediate, yIntermediate);
    }
    
    public bool noPiecesBlockingMvt (int x, int y)
    {       
        PieceBehaviour[] pieces = GameObject.FindObjectsOfType(typeof(PieceBehaviour)) as PieceBehaviour[];
        foreach (PieceBehaviour piece in pieces)
        {            
            if (piece.xPosition == x && piece.yPosition == y) return false;
        }        
        
        return true;
    }

}
