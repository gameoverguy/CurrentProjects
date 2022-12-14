using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicTower : MonoBehaviour {

	public TowerData[] TD;

	public SpriteRenderer TowerWeaponSprite;
	
	public SpriteRenderer TowerBaseSprite;
	
	public BasicTurret basicTurret;
	
	public int currentLevel;
	public int MaxLevel;


	// Use this for initialization
	void Start ()
	{
		MaxLevel = 4;
		
		currentLevel = 0;
	}
	
	// Update is called every frame, if the MonoBehaviour is enabled.
	void Update()
	{
		TowerBaseSprite.sprite = TD[currentLevel].TowerBaseSprite;
		TowerBaseSprite.color = TD[currentLevel].TowerBasecolor;
		
		TowerWeaponSprite.sprite = TD[currentLevel].TowerWeaponSprite;
		TowerWeaponSprite.color = TD[currentLevel].TowerWeaponcolor;
		
		basicTurret.Range = TD[currentLevel].TowerRange;
		basicTurret.startTimeBtwShots = TD[currentLevel].StartTimeBtwShots;
	}

}

