using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaBehaviour : PieceBehaviour {

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {        
        bool horizontalMov = (Math.Abs(yPosition - yNewPosition) == 1) && (Math.Abs(xPosition - xNewPosition) == 2);
        bool verticalMov = (Math.Abs(yPosition - yNewPosition) == 2) && (Math.Abs(xPosition - xNewPosition) == 1);

        int yIntermediate;
        int xIntermediate;

        if (horizontalMov)
        {
            yIntermediate = yPosition;
            xIntermediate = xNewPosition + ((xPosition - xNewPosition) / 2);
        }
        else
        {
            yIntermediate = yNewPosition + ((yPosition - yNewPosition) / 2);
            xIntermediate = xPosition;
        }
               

        return (horizontalMov || verticalMov) && noPiecesBlockingMvt(xIntermediate, yIntermediate);
    }
    
    public bool noPiecesBlockingMvt(int x, int y)
    {
        PieceBehaviour[] pieces = GameObject.FindObjectsOfType(typeof(PieceBehaviour)) as PieceBehaviour[];
        foreach (PieceBehaviour piece in pieces)
        {
            if (piece.xPosition == x && piece.yPosition == y) return false;
        }

        return true;
    }

}
