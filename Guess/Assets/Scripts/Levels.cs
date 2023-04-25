using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Levels : MonoBehaviour
{
	public GameObject manager;
	private Parameters parameter;
	private PassiveFunctions passivefunction;
	private AudioManager AM;
	
	// Awake is called when the script instance is being loaded.
	void Awake()
	{
		parameter = manager.GetComponent<Parameters>();
		passivefunction = manager.GetComponent<PassiveFunctions>();
		AM = manager.GetComponent<AudioManager>();
	}
	
	public void StartLevel01()
	{
		parameter.Lvl = 0;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel02()
	{
		parameter.Lvl = 1;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel03()
	{
		parameter.Lvl = 2;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel04()
	{
		parameter.Lvl = 3;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel05()
	{
		parameter.Lvl = 4;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel06()
	{
		parameter.Lvl = 5;
		passivefunction.StartLevelCommon();
	}
	
	public void StartLevel07()
	{
		parameter.Lvl = 6;
		passivefunction.StartLevelCommon();
	}
	

	
}
