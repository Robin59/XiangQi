//using System.Collections;
using System;
using UnityEngine;

public class ShuaiBehaviour : PieceBehaviour {

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        //check if it move from 1 position 
        bool onePositionAway = ((xPosition == xNewPosition) && (Math.Abs(yPosition - yNewPosition) == 1)) || ( (Math.Abs(xPosition - xNewPosition)==1) && (yPosition == yNewPosition));

        //check if still in palace 
        bool inPalace; 
        if (redPiece)
        {
            inPalace = (yNewPosition <= 2) && (xNewPosition >= 3) && (xNewPosition <= 5);
        }else{
            inPalace = (yNewPosition >= 7) && (xNewPosition >= 3) && (xNewPosition <= 5);
        }

        // interdiction for the 2 generals to face each other rule : TODO 

        return onePositionAway && inPalace;
    }

}
