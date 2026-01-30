using UnityEngine;

public class Array : MonoBehaviour
{
    //public o private | tipo de variable (string, gameobject, int, float...) | [] | nombre del array
    public string [] daysArray =
    {
        "lunes",
        "martes",
        "miercoles",
        "jueves",
        "viernes"
    };
    public GameObject [] objectArray = new GameObject[5];
    private int index =0;
    public void AddObject(GameObject newObject)
    {
        objectArray[index] = newObject;
        index++;
    }
}
