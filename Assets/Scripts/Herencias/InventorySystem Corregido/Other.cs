using UnityEngine;
using System;

namespace Inventory
{
	[Serializable]
	public class Other : Item, ISellable
	{
		[field: SerializeField] public float Price { get; set; }

		public float Sell()
		{
			UnityEngine.Debug.Log("Has ganado " + Price + " dineritos!");
			return Price;
		}
	}
}