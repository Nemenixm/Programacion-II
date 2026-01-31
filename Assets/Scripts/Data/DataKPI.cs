using UnityEngine;


//Un enum es una coleccion de etiquetas, que se pueden comportar como int.
//A veces se puede comportar como número y otras como etiqueta
public enum KPIType
{
    //Etiqueta = numero
    CollisionKPI = 0,
    SpawnedBallKPI = 1,
    ExplosionsKPI= 2
}
public class DataKPI : MonoBehaviour
{
    //Los enum al igual que las clases permiten crear variables
    public KPIType customKPI;
    private DataController dataController;

    void Awake()
    {
        dataController = Object.FindFirstObjectByType<DataController>();
    }
    public void SendData()
    {
        print("Seiding Data " + customKPI);
        dataController.SendData(customKPI);
    }
}
