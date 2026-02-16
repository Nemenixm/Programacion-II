using System;
using Inventory;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class ItemButtom : MonoBehaviour
{
    #region Properties
    public Button Button{get;set;}
    public Item CurrentItem
    {
        get
        {
            return _currentItem;
        }
        set
        {
            _currentItem=value;
            _buttonText.text =_currentItem.Name;
        }
    }
    public event Action Onclick;
    #endregion

    #region  Fields
    private TextMeshProUGUI _buttonText;
    private Button _button;
    private Item _currentItem;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        _button = GetComponent<Button>();
        _buttonText = GetComponentInChildren<TextMeshProUGUI>();
        //Delegate: Cuando creamos un método en la misma linea
        _button.onClick.AddListener(() => Onclick?.Invoke());
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
