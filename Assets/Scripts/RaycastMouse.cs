using UnityEngine;
using UnityEngine.InputSystem;

public class RaycastMouse : MonoBehaviour
{   
    //Nosotros elegimos que cámara y se la asignamos
    public Camera camera;
    public Rigidbody objectSelected=null;

    // Update is called once per frame
   /* void FixedUpdate()
    {
        //Coge la posición del ratón y desde la camara principal convierte esa posición en un rayo.
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            hit.collider.gameObject.SetActive(false);
            Debug.DrawLine(camera.transform.position, hit.point, Color.blue );
        }
    }*/

    //Lanza un rayo cuando hacemos click al objeto y lo desactiva
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(
                Mouse.current.position.ReadValue()
            );

            if (Physics.Raycast(ray, out hit))
            {   //Ejercicio de Raycast
                //hit.collider.gameObject.SetActive(false);
                //Ejercicio Practia I cañon
                objectSelected =hit.rigidbody;
            }
        }
    }
}
