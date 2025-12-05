// using UnityEngine;

// public class CameraPov : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     public Transform ball;
//     void LateUpdate()
//     {
//         // follow the ball position
//         transform.position = ball.position;

//         // keep camera upright
//         Quaternion currentRot = transform.rotation;
//         transform.rotation = Quaternion.Euler(0, currentRot.eulerAngles.y, 0);
//     }

// }


using UnityEngine;

public class CameraPov : MonoBehaviour
{
    public Transform ball;

    void LateUpdate()
    {
        if (ball == null) return;

        // Follow the ball's position
        transform.position = ball.position;

        // Keep camera upright but face same direction as ball
        Vector3 forward = ball.forward;
        forward.y = 0; // flatten so camera doesn't tilt
        transform.rotation = Quaternion.LookRotation(forward);
    }
}
