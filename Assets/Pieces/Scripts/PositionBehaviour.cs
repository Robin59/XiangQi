using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[System.Serializable]
public class PositionClicked : UnityEvent<byte, byte> { }

public class PositionBehaviour : MonoBehaviour {

    public byte x;
    public byte y;
    public PositionClicked positionClicked = new PositionClicked();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClicked()
    {
        positionClicked.Invoke(x, y);
    }


}
