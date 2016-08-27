using UnityEngine;
using System.Collections;

public class BingBehaviour : PieceBehaviour {

    public override bool movement_Possible(int xNewPosition, int yNewPosition)
    {
        return true;
    }        
	
}
