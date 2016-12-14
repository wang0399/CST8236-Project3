using UnityEngine;
using System.Collections;

public class sunSelfRotation : MonoBehaviour { 

     public int rotationSpeed;

	// Update is called once per frame
	void Update () {

        if (rotationSpeed == 0)
            rotationSpeed = 30; //default speed

        transform.Rotate(new Vector3(5, 0, 0), rotationSpeed * Time.deltaTime);

    }
}
