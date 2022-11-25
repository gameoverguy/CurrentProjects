using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	[SerializeField]private GameObject tile;
	
    // Start is called before the first frame update
    void Start()
    {
	    CreateTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	private void CreateTile()
	{
		float tileSize = tile.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
		
		for (int y = -6; y < 7; y++) 
		{
			for (int x = -11; x < 12; x++) 
			{
				GameObject newTile = Instantiate(tile);
				newTile.transform.position = new Vector3(tileSize * x, tileSize * y, 0);
			}
		}
	}
	
	
}
