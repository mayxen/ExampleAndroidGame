using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneManager : MonoBehaviour {

    public Text infoText;
    public Player3D player;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        infoText.text = "No input detected";
        List<Vector2> touchCoordinates = new List<Vector2>();
        //actual touches
        foreach (Touch touch in Input.touches)
        {

            touchCoordinates.Add(touch.position);
        }
        
        //print input info 
        if (touchCoordinates.Count > 0)
        {
            infoText.text = "";
            for (int i = 0; i < touchCoordinates.Count; i++)
            {
                infoText.text += string.Format("Input {0}: {1}, {2} \n", i + 1, touchCoordinates[i].x, touchCoordinates[i].y);
            }
        }

        if (touchCoordinates.Count == 2)
        {
            player.ActivateSpeedUp();
        }
        else if (touchCoordinates.Count == 3)
        {
            player.ActivateInvincibility();
        }
    }
}
