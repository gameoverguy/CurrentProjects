using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
	public static UIManager instance;
	public TextMeshProUGUI player0HealthText, player0ManaText, player1HealthText, player1ManaText;
	public GameEndUIController gameEndUI;
	
	// Awake is called when the script instance is being loaded.
	private void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void GameFinished(Player winner)
	{
		gameEndUI.gameObject.SetActive(true);
		gameEndUI.Initialize(winner);
	}
    
	public void UpdateValues(Player player0, Player player1)
	{
		UpdateHealthValues(player0.health, player1.health);
		UpdateManaValues(player0.mana, player1.mana);
	}
    
	public void UpdateHealthValues(int player0Health, int player1Health)
	{
		player0HealthText.text = player0Health.ToString();
		player1HealthText.text = player1Health.ToString();
	}
	
	public void UpdateManaValues(int player0Mana, int player1Mana)
	{
		player0ManaText.text = player0Mana.ToString();
		player1ManaText.text = player1Mana.ToString();
	}
}
