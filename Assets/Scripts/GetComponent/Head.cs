using UnityEngine;

public class Head : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void AddForce(float force)
    {
        GetComponent<Rigidbody>().AddForce(0, force, 0);
    }
}
