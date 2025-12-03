using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // !! UNDERSTAND THE CODE !!
    // get the code running first!


    private Rigidbody rb; //we set it private as we dont need to access this variable from other scripts
    private float movementX;
    private float movementY;
    public float speed = 0; // public variable so we can access this from the inspector under playerScript

    //a function is VOID when it does not return anything
    void Start() //Start() runs once, right when the object appears in the game.
    {
        rb = GetComponent <Rigidbody>(); //this gets the rigidBody from the game object and sets to rb. If the rigidbody is on a PlayerObject, unity looks at the player, finds its rigidbody and sets to rb.
    }
    void OnMove(InputValue movementValue) //This function runs every time the player gives movement input.
    {
        // Convert the input value into a Vector2 for movement.
        // Vector2 == 2D. It create a Vector2 variable called movementVector and store a value in it
         Vector2 movementVector = movementValue.Get<Vector2>();  // get the player's movement input as a 2D vector (x/y)
         movementX = movementVector.x;
         movementY = movementVector.y;
    }
    void FixedUpdate() // runs at a fixed rate (for physics) and used for applying Rigidbody force/movement
    {
     // Create a 3D movement vector using the X and Y inputs.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed); // movement will be now based on the speed we set in inspector
    }

    // Update is called once per frame
    // void Update()
    // {
        // no need of update() function now
    // }
}
