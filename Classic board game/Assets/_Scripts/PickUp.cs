using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
        void LateUpdate()
        {

            float LeftRight = Input.GetAxis("Horizontal");
            float BackForth = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(BackForth, 0.0f, LeftRight);

            transform.Rotate(movement);

            /* if (LeftRight< 15)
             {
                 if (BackForth< 15)
                 {

                 }
             }
             */

        }
}
