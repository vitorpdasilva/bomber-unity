using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject bomb;
	private float minX = -2.55f;
	private float maxX = 2.55f;
    
    void Start()
    {
        StartCoroutine(spawnBombs());
    }

    IEnumerator spawnBombs () {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        
        Instantiate(bomb, new Vector2(Random.Range(minX, maxX), transform.position.y),
            Quaternion.identity);
        StartCoroutine(spawnBombs());
    }
}
