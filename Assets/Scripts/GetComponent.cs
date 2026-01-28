using UnityEngine;
using UnityEngine.InputSystem;

//Esto sirve para cuando estemos utilizando estos componentes, y desaparecen del objeto el código se rompería.
//Esto bloquea el poder eliminar estos componentes del objeto. Ya que este scipt depende de ellos
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class GetComponent : MonoBehaviour
{

    public Color color;
    public Color color2;
    
    void Start()
    {
        
    }

    
    private void FixedUpdate()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            GetComponent<MeshRenderer>().material.color=color;
            GetComponentInChildren<MeshRenderer>().material.color=color2;
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame) { }
        {
            GetComponent<Rigidbody>().AddForce(0,1,0);
            GetComponentInChildren<Head>().AddForce(1);

            //Para activar o desactivar componentes
            //Aunque este sea InChildren, desactivará el primer Mesh Renderer que encuentre, en este caso,
            //el padre también tiene  el mismo componente, por lo que será ese el que desactivara.
            //GetComponentInChildren<MeshRenderer>().enabled=false;

            //Podemos acceder al componente transform
            GetComponentInChildren<Head>().transform.Translate(1,0,0);

            //Podemos acceder a la camara
            //Alejara el campo de vision *2
            Camera.main.fieldOfView *=2;
            //Mover la camara hacia delante
            Camera.main.transform.Translate(0,0,1);
        }
    }   
}
