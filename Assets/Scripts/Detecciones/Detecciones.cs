using UnityEngine;

public class Detecciones : MonoBehaviour
{
    public bool floorContact;
    //OnCollisionEnter2D para juegos 2D
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            print("Toque");
        }
        if (collision.gameObject.tag == "floor")
        {
            floorContact=true;
            print("Esta tocando el suelo");
        }
    }
    private void OllisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            floorContact = false;
        }
    }
}