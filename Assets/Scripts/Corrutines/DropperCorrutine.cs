using System.Collections;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DropperCorrutine : MonoBehaviour
{
    
    public GameObject ballPrefab;
    void Start()
    {   //Genera números aleatorios entre 1f y 5f, incluido el 5f, ya que los estamos poniendo en float "f".
        //Si no pusieramos "f", serian enteros por lo que no incluiria el 1 y 5
        float repeatRate =Random.Range(1f,5f);
        StartCoroutine(Drop(repeatRate));
        
    }

    //Ienumerator se le condidera a cualquier tipo de colección. Los arrays y listas implementan Ienumerator
    //También se utiliza para atrasar porcesos (generar esperas).
    IEnumerator Drop(float rateTime)
    {
        //Espera de un frame
        //yield return null;
    
        while (true)
        {    //Formula para esperar segundos
            yield return new WaitForSeconds(rateTime);
           //GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
            //Para instanciar solo el 33% de las veces
            float probability = Random.Range(0,3);
            if (probability == 0)
            {
                Instantiate(ballPrefab, transform.position, Quaternion.identity);
            }
        }
    }
    

    
    
}
