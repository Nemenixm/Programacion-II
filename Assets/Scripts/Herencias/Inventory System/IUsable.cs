using UnityEngine;
using UnityEngine.InputSystem;

//De esta manera protegemos nuestros scripts de que nunca entren en conflicto con otros
//scripts de otro proyecto
namespace Inventory
{
//Las interfaces solo puede tener propiedades y métodos públicos
//Las interfaces no puede tener ni propiedades privadas ni métodos privados
public interface IUsable
{
    #region Properties
    #endregion


    #region Public Methods
    public void Use();
    #endregion
    
   
}
}
