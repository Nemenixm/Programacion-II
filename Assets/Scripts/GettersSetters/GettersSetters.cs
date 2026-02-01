using UnityEngine;

public class GettersSetters : MonoBehaviour
{
    //Las regiones son comentarios 2.0, ya que nos permiten recoger el nombre. 
    //#region Nombre del bloque -> bloque -> #endregion
    #region Properties
    public int Points {get;set;}
    #endregion

    #region  Fields
    private int _levelPoints=1000;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        Points=100;
        Debug.Log("Points " + Points);
        _levelPoints*=2;
    }

    
    void Update()
    {
        
    }
    #endregion
    #region Public Methods

    #endregion
    #region Private Methods
   
    #endregion
}
