using UnityEngine;
using UnityEngine.InputSystem;
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
