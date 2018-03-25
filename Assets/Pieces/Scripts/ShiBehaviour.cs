using System;
using UnityEngine;

public class ShiBehaviour : PieceBehaviour {

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        bool diagonalMov = (Math.Abs(yPosition - yNewPosition) == 1) && (Math.Abs(xPosition - xNewPosition) == 1);


        //check if still in palace 
        bool inPalace;
        if (redPiece)
        {
            inPalace = (yNewPosition <= 2) && (xNewPosition >= 3) && (xNewPosition <= 5);
        }
        else
        {
            inPalace = (yNewPosition >= 7) && (xNewPosition >= 3) && (xNewPosition <= 5);
        }

        return inPalace && diagonalMov;
    }
}
