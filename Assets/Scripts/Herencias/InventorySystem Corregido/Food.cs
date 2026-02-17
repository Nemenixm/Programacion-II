
using System;
using UnityEngine;

namespace Inventory
{
	public interface IConsumable { }

	[Serializable]
	public class Food : Item, IUsable, ISellable,IConsumable
	{
		#region Properties
		[field: SerializeField] public float HealingPoints { get; set; }
		[field: SerializeField] public float Price { get; set; }

		public float Sell()
		{
			UnityEngine.Debug.Log("Has ganado " + Price + " dineritos!");
			return Price;
		}

		public void Use()
		{
			UnityEngine.Debug.Log("Te comes " + Name + " y ganas " + HealingPoints + " vidas!!");
		}
		#endregion

	}
}