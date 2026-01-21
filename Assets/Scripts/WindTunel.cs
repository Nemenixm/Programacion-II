using UnityEditor.Search;
using UnityEngine;

public class WindTunel : MonoBehaviour
{
public float force=10;



    private void OnTriggerStay(Collider other)
    {
       other.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
    }
}
