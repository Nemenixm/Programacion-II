using UnityEngine;
using UnityEngine.InputSystem;
/*
//De esta manera protegemos nuestros scripts de que nunca entren en conflicto con otros
//scripts de otro proyecto
namespace Inventory
{
                //Hereda de Item, pero podemos poner tantas interfaces como queramos
public class Other : Item, ISellable
{

    
    #region Properties
     public float Price { get; set; }
    #endregion


    
    #region Public Methods
        public float sell()
    {
        UnityEngine.Debug.Log("Has ganado " + Price + " monedas");
        return Price;;
    }
    #endregion
    
}
}
*/