using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    //Este código solo servira para tener una atajo al Rigibody de la ball
    //Usamos [System.NonSerialized] no nos aparecerá en el inspector, 
    //ya que se asignara automaticamente, mientras lo podamos coger con el GetComponent
    [System.NonSerialized]
    public Rigidbody myRigidbody;

    private void Awake()
    {
        myRigidbody=GetComponent<Rigidbody>();
    }
}
