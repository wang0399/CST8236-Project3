using UnityEngine;
using System.Collections;

public class radarRotation : MonoBehaviour
{

    public int rotationSpeed;

    void Update()
    {

        if (rotationSpeed == 0)
            rotationSpeed = 30; //default speed
      
        transform.Rotate(new Vector3(0, 10, 0), rotationSpeed * Time.deltaTime);
    }
}