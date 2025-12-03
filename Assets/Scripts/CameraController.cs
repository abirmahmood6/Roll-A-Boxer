using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference to the player GameObject.
    public GameObject player;
    // The distance between the camera and the player.
    private Vector3 offset;
    
     // Start is called before the first frame update.
    void Start()
    {
        // Calculate the initial offset between the camera's position and the player's position.
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() //we convert this from Update -> LateUpdate as the camera position must be updated at last and later than the other update functions we may have. Otherwise, the position may be affected resulting in inaccurate position.
    {
        // LateUpdate is called once per frame after all Update functions have been completed.
        // Maintain the same offset between the camera and player throughout the game.
        transform.position = player.transform.position + offset;
    }
}
