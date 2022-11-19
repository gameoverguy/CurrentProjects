using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tower", menuName = "Tower")]
public class TowerData : ScriptableObject
{
	//public int ID;

	public Sprite TowerBaseSprite;
	public Sprite TowerWeaponSprite;
	public Color TowerBasecolor;
	public Color TowerWeaponcolor;
	
	public float TowerRange;
	public float StartTimeBtwShots;

}

