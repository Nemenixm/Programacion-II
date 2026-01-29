using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    
    public Ball ballPrefab;
    [Header("Shoot")]
    public Transform spawnPoint;
    [Header("Movement")]
    public float speedRotation=100;
    public float shootForce=100;


    private void Start()
    {
        transform.rotation=Quaternion.identity;
    }

    void Update()
    {
        //Para poder controlar la camara
        float mouseY = Mouse.current.delta.ReadValue().y;

        transform.Rotate(
        Vector3.right * mouseY * speedRotation * Time.deltaTime
    );
    //Spawn & Addforce
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            //Instantiate(que queremos instanciar, donde lo queremos instanciar)
            //Instantiate(ballPrefab, spawnPoint);
            //Instantiate también puede guardar un valor.Pero entonces la bola se convertiria en gameObject
            Ball ball = Instantiate(ballPrefab, spawnPoint);
            ball.myRigidbody.AddForce(transform.forward*shootForce);
        }
    }
}
