using UnityEngine;
using UnityEngine.InputSystem;

//Las interfaces solo puede tener propiedades y métodos públicos
//Las interfaces no puede tener ni propiedades privadas ni métodos privados

public interface ISellable 
{
    #region Properties
    public float Price {get;set;}
    #endregion

    
    
    #region Public Methods
    public float sell();

    #endregion
    
   
}
