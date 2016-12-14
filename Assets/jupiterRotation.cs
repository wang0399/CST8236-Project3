using UnityEngine;
using System.Collections;

public class jupiterRotation : MonoBehaviour {

    public int rotationSpeed;

    void Update()
    {

        if (rotationSpeed == 0)
            rotationSpeed = 30; //default speed

        transform.RotateAround(transform.parent.position, Vector3.up, rotationSpeed * Time.deltaTime * 0.08f);

        transform.Rotate(new Vector3(0, 4, 0), rotationSpeed * Time.deltaTime);

    }
}
