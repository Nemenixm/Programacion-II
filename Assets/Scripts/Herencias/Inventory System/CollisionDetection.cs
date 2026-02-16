using UnityEngine;
using UnityEngine.InputSystem;
using Inventory;

public class CollisionDetection : MonoBehaviour
{

    #region Unity Callbacks
    private void OnCollisionEnter(Collision collision)
    {
      
        UnityEngine.Debug.Break();
    }
    #endregion


}
