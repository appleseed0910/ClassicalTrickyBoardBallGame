using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

    public Text GreetingText;
    public Text WinText;
    private int count;

    // Use this for initialization
    void Start () {
        count = 0;
        SetCountText();
        WinText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        if (count == 0)
        {
            GreetingText.text = "welcome. Try to tilt the board?";
        }
        else if (count >= 1 && count <= 3)
        {
            GreetingText.text = "Ha! Congrats, it's easy to figure out you should pick them up";
        }
        else if (count > 3 && count < 6)
        {
            GreetingText.text = "But still, be careful! Or you will have a journey to the center of the Earth!";
        }
        else if (count == 6)
        {
            GreetingText.text = "You almost did it!";
        }
        else if (count == 7)
        {
            GreetingText.text = "";
            WinText.text = "OOOOHCongrats!";
        }
    }
}


