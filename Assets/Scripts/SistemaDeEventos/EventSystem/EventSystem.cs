using UnityEngine;
using UnityEngine.InputSystem;

public class EventSystem : MonoBehaviour
{
    #region Properties
    #endregion

    #region  Fields
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _ui;
    [SerializeField] private SoundController _sound;
    
    #endregion

    #region Unity Callbacks
    void Start()
    {
        //_playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnDie += () => Debug.Log("You Die");
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
