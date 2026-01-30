using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class List : MonoBehaviour

{
    //Desde el inspector pondremos el prefab de la explosion (descargado en AssetsStore)
    public GameObject explosionPrefab;
    /* Public o Private | List (palabra clave) | 
    <tipo de objeto que quiero crear en la lista> (Gameobject, string, int, float...) | 
    nombre de la lista | = | Inicialización de la lista
    LAS LISTAS SIEMPRE SE INICIALIZAN*/
    public List<GameObject> objectList = new List<GameObject>();

    public int limitObject =20;

    //Añadir elementos a la lista
    public void AddObject(GameObject ball)
    {
        objectList.Add(ball);

        //Si son mas de 20 objetos, explotaran, gracias al método que creamos mas abajo.
        if (objectList.Count > 20)
        {
            ExplosionAll();
        }
    }

    private void ExplosionAll()
    {
        //For generico para recorrer listas
        for (int i = 0; i< objectList.Count; i++)
        {   
            //Recorre la lista destruyendo los objetos
            Destroy(objectList[0]);
            //Instanciamos una explosion en cada uno de ellos
            Instantiate(explosionPrefab, objectList[0].transform.position, quaternion.identity);
        }
        objectList.Clear();
    }
}
