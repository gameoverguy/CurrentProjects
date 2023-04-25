using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamePlayUIController : MonoBehaviour
{
	public static GamePlayUIController instance;
	public TextMeshProUGUI currentPlayerTurn;
	
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
    
	public void UpdateCurrentPlayerTurn(int ID)
	{
		currentPlayerTurn.gameObject.SetActive(true);
		currentPlayerTurn.text = $"Player{ID+1}'s Turn";
		
		StartCoroutine(BlinkCurrentPlayerTurn());
	}
	
	public IEnumerator BlinkCurrentPlayerTurn()
	{
		yield return new WaitForSeconds(0.5f);
		currentPlayerTurn.gameObject.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		currentPlayerTurn.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		currentPlayerTurn.gameObject.SetActive(false);
		yield return new WaitForSeconds(0.5f);
		currentPlayerTurn.gameObject.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		currentPlayerTurn.gameObject.SetActive(false);
	}
}
















