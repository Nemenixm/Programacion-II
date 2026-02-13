using UnityEngine;
using UnityEngine.InputSystem;
                    //Hereda de Item, pero podemos poner tantas interfaces como queramos
public class Food : Item, IUsable, ISellable
{
    
    #region Properties
    public float HealingPoints {get;set;}
    public float Price { get; set; }
    #endregion

    #region  Fields
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
    public void Use()
    {
        UnityEngine.Debug.Log("Te comes "+ Name + " y ganas " + HealingPoints + " de vida");
    }

    public float sell()
    {
        UnityEngine.Debug.Log("Has ganado " + Price + " monedas");
        return Price;
    }

    #endregion
    #region Private Methods
    #endregion

}
