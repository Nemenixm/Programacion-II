using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Health : MonoBehaviour
{
    #region Properties
    public float CurrentHealt {

        get
        {
            return _currentHealt;
        }
        set
        {
            _currentHealt =value;
            if (value < 0)
            {
                _currentHealt=0;
                Die();
            }
            if (value > _maxHealt)
            {
                _currentHealt = _maxHealt;
            }
        }
    }
    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;
    #endregion

    #region  Fields
    [SerializeField] private float _maxHealt=100;
    [SerializeField] private float _currentHealt;
    private bool _die = false;
    #endregion

    #region Unity Callbacks
    void Start()
    {
        CurrentHealt = _maxHealt;
       
        //Event Listener
        //Si es un campo que esta controlado por una propiedad, accedemos a la propiedad.
        //Para asegurarnos de pasar siempre por los filtros y controles internos
        OnGetDamage += () => Debug.Log("Life: " + CurrentHealt);
        OnDie += () => Debug.Log("You Die");
        GetDamage(20);
        GetDamage(100);
        GetDamage(50);
        
    }

    
    void Update()
    {
        
    }
    #endregion
    #region Public Methods
        public void GetDamage(float damage)
    {
        CurrentHealt -= damage;
        //Event Emiter
        //Lanzamos el evento. Esto hara que se lance el evento y que todos los que esten suscritos a él lance sus acciones
        //Con ? preguntamos si el evento es nulo, si es nulo no se lanza. Asi evitamos el error si no hay nadie suscripto a este evento.
        //No hay nadie suscrito, no hace nada, no lo invoques. No da error
        OnGetDamage?.Invoke();
    }
        public void GetHeal(float life)
    {
        CurrentHealt += life;
        //Event Emiter
        //Lanzamos el evento. Esto hara que se lance el evento y que todos los que esten suscritos a él lance sus acciones
        //Con ? preguntamos si el evento es nulo, si es nulo no se lanza. Asi evitamos el error si no hay nadie suscripto a este evento.
        //No hay nadie suscrito, no hace nada, no lo invoques. No da error
        OnGetHeal?.Invoke();
    }
    #endregion
    #region Private Methods

    private void Die()
    {
        if (!_die)
        {
        _die =true;
        //Die Event Emiter
        //Lanzamos el evento. Esto hara que se lance el evento y que todos los que esten suscritos a él lance sus acciones
        //Con ? preguntamos si el evento es nulo, si es nulo no se lanza. Asi evitamos el error si no hay nadie suscripto a este evento.
        //No hay nadie suscrito, no hace nada, no lo invoques. No da error
        OnDie?.Invoke();

        }
        
    }
    #endregion
   
}
