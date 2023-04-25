using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cash : MonoBehaviour
{
	public TextMeshProUGUI CashText;
	public TextMeshProUGUI ReactorStrength;
	public TextMeshProUGUI Waves;
	
	public float StartingCash = 200f;
	public float CurrentCash;
	public int currentReactorStr;
	public int currentWave;
	public int TotalWaves;
	
	public GameObject missionFailed;
    // Start is called before the first frame update
    void Start()
    {
	    CurrentCash = StartingCash;
	    currentWave = 0;
	    currentReactorStr = 10;
    }

    // Update is called once per frame
    void Update()
    {
	    CashText.text = CurrentCash.ToString();
	    ReactorStrength.text = currentReactorStr.ToString();
	    Waves.text = currentWave.ToString() + " / " + TotalWaves.ToString();
	    
	    if(currentReactorStr <= 0)
	    {
	    	Time.timeScale = 0;
	    	missionFailed.SetActive(true);
	    	currentReactorStr = 10;
	    }
	    
    }
}
