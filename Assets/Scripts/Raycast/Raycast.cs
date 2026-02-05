using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Raycast : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        //Velocidad de rotacion de la capsula
        transform.Rotate(0, 100*Time.deltaTime, 0);
        UnityEngine.Debug.DrawRay(transform.position, transform.forward,Color.black);
    }
    void FixedUpdate()
    {
        //Secuencia minima de objetos que hay que crear en un Raycast
        //Para guardar la información de si se produce un hit
       RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)){
            
            //Mientras esta impactando se dibuja una linea roja
           UnityEngine.Debug.DrawRay(transform.position, hit.point, Color.red);
            print("Hit! " + hit.collider.name);
            print("Point! " + hit.point);
            print("Normal! " + hit.normal);
           
        }
        /*Para apuntar de forma automatica
       if (Physics.SphereCast(transform.position, 1, transform.forward, out hit))
        {
            print("Hit! " + hit.rigidbody);
        }*/
    }
}
