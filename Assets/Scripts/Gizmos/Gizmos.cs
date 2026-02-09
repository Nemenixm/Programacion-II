using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gizmos : MonoBehaviour
{
    #region Properties
    #endregion

    #region  Fields
    [Header("Gizmo Line")]
    [SerializeField] private Vector3 initialGizmoLine;
    [SerializeField] private Vector3 finalGizmoLine;
    [Header("Gizmo Area")]
    [SerializeField] private float _visionLenght =10;
    [Header("Detection Area")]
    [SerializeField] private float _visionArea= 10;
    [SerializeField] private float _audioArea= 10;

    #endregion

    #region Unity Callbacks
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    #endregion
    #region Public Methods

    #endregion
    #region Private Methods
    #endregion

    #region Gizmos
    private void OnDrawGizmos()
    {
        UnityEngine.Gizmos.color= Color.white;
        UnityEngine.Gizmos.DrawLine(initialGizmoLine, finalGizmoLine); 
        UnityEngine.Gizmos.DrawWireSphere(Vector3.zero, _visionArea);
        UnityEngine.Gizmos.color= Color.red;
        UnityEngine.Gizmos.DrawLine(Vector3.zero, _visionLenght * (Vector3.forward + Vector3.right));  
        UnityEngine.Gizmos.DrawLine(Vector3.zero, _visionLenght * (Vector3.forward + Vector3.left)); 
        UnityEngine.Gizmos.color= Color.red;
        UnityEngine.Gizmos.DrawWireSphere(Vector3.zero, _audioArea); 
    }
    #endregion

}
