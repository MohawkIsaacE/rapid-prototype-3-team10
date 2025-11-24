using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraRotate : MonoBehaviour
{
    public Camera Cam;
    public Transform CueBall;
    public float CameraSpeed = 2f;
    public float distanceToTarget = 10f;

    private Vector3 previousPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            previousPosition = Cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(1))
        {
            Vector3 newPosition = Cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180; // camera moves horizontally
            float rotationAroundXAxis = direction.y * 180; // camera moves vertically

            Cam.transform.position = CueBall.position;

            //Cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            Cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World); // <— This is what makes it work!

            Cam.transform.Translate(new Vector3(0, 0.3f, -distanceToTarget));

            previousPosition = newPosition;
        }
        else // Follow the ball even when not aiming
        {
            Vector3 newPosition = Cam.ScreenToViewportPoint(Input.mousePosition);

            Cam.transform.position = CueBall.position;

            Cam.transform.Translate(new Vector3(0, 0.3f, -distanceToTarget));

            previousPosition = newPosition;
        }
    }
}
