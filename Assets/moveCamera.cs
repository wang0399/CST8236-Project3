using UnityEngine;
using System.Collections;

public class moveCamera : MonoBehaviour {

    public int moveSpeed;

    public Vector2 maxAngles;

    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;

        //Camera thisCamera = GetComponent<Camera>();

        // Get the size of the screen, and the center for use later.
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenCenter = screenSize / 2.0f;

        // Get the vector that represents how far you are from the center.
        Vector2 difference = mousePosition - screenCenter;
        Vector2 deltaPercentage = new Vector2(difference.x / screenCenter.x, difference.y / screenCenter.y);

        Vector2 newAngle = new Vector2(deltaPercentage.x * maxAngles.x, deltaPercentage.y * maxAngles.y);

        transform.localRotation = Quaternion.Euler(-newAngle.y, newAngle.x, 0.0f);
  

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
        }
    }
}
