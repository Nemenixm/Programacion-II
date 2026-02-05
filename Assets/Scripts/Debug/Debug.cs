
using UnityEngine;
using UnityEngine.InputSystem;

public class Debug : MonoBehaviour
{
    #region Properties
    #endregion

    #region  Fields
    private int _cont=0;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        UnityEngine.Debug.Log("Mensaje");
        UnityEngine.Debug.LogWarning("Mensaje tipo Warning");
        UnityEngine.Debug.LogError("Mensaje tipo Error!!!");
    }

    
    void Update()
    {
        _cont++;
        if(_cont % 100 == 0){
           UnityEngine.Debug.Log("La cantidad: " + _cont);
        }
    }
    #endregion
    #region Public Methods

    #endregion
    #region Private Methods
    #endregion
   
}
