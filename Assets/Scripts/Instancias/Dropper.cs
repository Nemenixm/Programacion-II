using UnityEngine;
using UnityEngine.InputSystem;

public class Dropper : MonoBehaviour
{
    public float repeatRate =1;
    public GameObject ballPrefab;
    
    void Start()
    {
        //Nos permite ejecutar un método al cabo de un tiempo
        //Invoke
        //Nos permite invocar un método cada cierto tiempo
        //InvokeRepeating("Nombre del parametro", cuando queremos que se ejecute por primera vez, cada cuanto queremos que se repita)
        InvokeRepeating("Drop", 0, repeatRate);
    }

    
    void Drop()
    {   //Instantiate(que queremos instanciar, donde lo queremos instanciar, con rotacion zero(Quaternion.identity)=0,0,0 en Rotación.
        //Guardamos la bola instanciada en ball, aunque no hagamos anda con ella.
        GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }
}
