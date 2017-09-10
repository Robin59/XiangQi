using UnityEngine;
using System.Collections;

public class BingBehaviour : PieceBehaviour {

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        bool lateralMvt = false;
        if (redPiece) 
        {           
            if (yPosition > 4)//the river is cross
            {
                lateralMvt = ((xPosition + 1 == xNewPosition) && (yPosition == yNewPosition)) || ((xPosition - 1 == xNewPosition ) && (yPosition == yNewPosition));
            }
            return lateralMvt || ((xPosition == xNewPosition) && (yPosition + 1 == yNewPosition ));
        }
        else
        {
            if (yPosition < 5)//the river is cross
            {
                lateralMvt = ((xPosition + 1 == xNewPosition ) && (yPosition == yNewPosition)) || ((xPosition - 1 == xNewPosition ) && (yPosition == yNewPosition));
            }
            return lateralMvt || ((xPosition == xNewPosition) && (yPosition - 1 == yNewPosition ));
        }               
    }        
	
}
