using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//De esta manera protegemos nuestros scripts de que nunca entren en conflicto con otros
//scripts de otro proyecto
namespace Inventory
{
[Serializable]
public class InventorySystem : MonoBehaviour
{
    #region Properties
    #endregion

    #region  Fields
    [Header("UI Reffs")]
    [SerializeField] private ItemButtom _prefabButton;
    //Creamos una coleccion para cada tipo
    [Header("Object Definition")]
    [SerializeField] private Weapon [] _weapons;
    [SerializeField] private Food [] _food;
    [SerializeField] private Other [] _other;
    [Header("Item pool")]
    [SerializeField] private List<Item> _items = new List<Item>();
    #endregion

    #region Unity Callbacks
    void Start()
    {
        //Weapons
        for (int i=0; i < _weapons.Length; i++)
        {
            _items.Add(_weapons[i]);
        }
         //Food
        for (int i=0; i < _food.Length; i++)
        {
            _items.Add(_food[i]);
        }
         //Other
        for (int i=0; i < _other.Length; i++)
        {
            _items.Add(_other[i]);
        }
        
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
}