using UnityEngine;
using UnityEngine.InputSystem;
                //Hereda de Item, pero podemos poner tantas interfaces como queramos
public class Weapon : Item, IUsable

{
    #region Properties
    [SerializeField] public float Damage{get;set;}
    #endregion

    #region  Fields
    #endregion

  
    
    #region Public Methods

    public void Attack()
    {
        UnityEngine.Debug.Log("Do attack...");
    }

    public void Use()
    {
        Attack();
    }


    #endregion
    #region Private Methods
    #endregion

}
