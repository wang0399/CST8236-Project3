using UnityEngine;
using System.Collections;

public class neptuneRotation : MonoBehaviour {

    public int rotationSpeed;

    void Update()
    {

        if (rotationSpeed == 0)
            rotationSpeed = 30; //default speed

        transform.RotateAround(transform.parent.position, Vector3.up, rotationSpeed * Time.deltaTime * 0.005f);

        transform.Rotate(new Vector3(0, 8, 0), rotationSpeed * Time.deltaTime);
    }
}
