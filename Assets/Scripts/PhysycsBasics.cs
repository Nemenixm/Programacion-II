using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.InputSystem;


public class PhysycsBasics : MonoBehaviour
{
    public Rigidbody playerRigibody;
    /*Para juegos 2D
    public Rigidbody2D playerRigibody;*/
    public float jumpForce;
    public float speedMove;
    public Detecciones detector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Dos maneras diferentes de hacer lo mismo
        //playerRigibody.AddForce(0,1000,0);
        //playerRigibody.AddForce(Vector3.up *1000);
        
    }

    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame && detector.floorContact ==true)
        {
            playerRigibody.AddForce(Vector3.up * jumpForce);
        }

        Vector3 moveDirection = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
            moveDirection += Vector3.forward;

        if (Keyboard.current.sKey.isPressed)
            moveDirection += Vector3.back;

        if (Keyboard.current.aKey.isPressed)
            moveDirection += Vector3.left;

        if (Keyboard.current.dKey.isPressed)
            moveDirection += Vector3.right;

        playerRigibody.AddForce(moveDirection.normalized * speedMove, ForceMode.Force);

    }
    void UpdatfixedUpdate()
    {
        //Nuevo sistema de Input
       // if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
       // {
       //     playerRigibody.AddForce(Vector3.up *jumpForce);
       // }

       /* (Keyboard.current.upArrowKey.isPressed ? 1f : 0f) -
        (Keyboard.current.downArrowKey.isPressed ? 1f : 0f);

        Vector3 force = new Vector3(0, 0, vertical) * speedMove;
        playerRigibody.AddForce(force);*/
    }
}
