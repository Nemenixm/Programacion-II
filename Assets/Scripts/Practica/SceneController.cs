using UnityEngine;

public class SceneController : MonoBehaviour
{
    [Range(30,80)]
    public float anguloCañon;
    [Range(100,1000)]
    public float cañonForce;
    public Transform cañon;
    public Transform cañonSpawnPoint;
    public Rigidbody sphereProyectile;
    public Rigidbody sphere2Proyectile;
    public RaycastMouse raycastMouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cañon.rotation=Quaternion.Euler(anguloCañon, 0, 0);
        //Seleccionador
        if (raycastMouse.objectSelected != null)
        {
            
        }
    }
}
