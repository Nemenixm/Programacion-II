using UnityEngine;
using UnityEngine.InputSystem;


public class PhysycsBasics : MonoBehaviour
{
    public Rigidbody playerRigibody;
    public float jumpForce;
    public float speedMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Dos maneras diferentes de hacer lo mismo
        //playerRigibody.AddForce(0,1000,0);
        //playerRigibody.AddForce(Vector3.up *1000);
        
    }

    void Update()
    {
        if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
        {
            playerRigibody.AddForce(Vector3.up *jumpForce);
        }
    }
    void UpdatfixedUpdate()
    {
        //Nuevo sistema de Input
       // if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
       // {
       //     playerRigibody.AddForce(Vector3.up *jumpForce);
       // }

        float vertical =
        (Keyboard.current.upArrowKey.isPressed ? 1f : 0f) -
        (Keyboard.current.downArrowKey.isPressed ? 1f : 0f);

        Vector3 force = new Vector3(0, 0, vertical) * speedMove;
        playerRigibody.AddForce(force);
    }
}
