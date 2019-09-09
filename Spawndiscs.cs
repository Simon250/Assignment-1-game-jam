using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This should go on Main Camera in Unity
//script which Spawns discs at points just outside of the screenbounds
//

public class Spawndiscs : MonoBehaviour{
    public GameObject discPrefab;//loads discPrefab into code
    public float SpawnTime = 1.0f;//Default spawn time
    private Vector2 screenBounds;//Finds screen size

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(DiscSpawns());
    }
    public void SpawnDiscs () //Method which spawns Discs
    {
        GameObject a = Instantiate(discPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x + 8, Random.Range(-screenBounds.y, screenBounds.y)); //Spawns discs at random y value
    }
    IEnumerator DiscSpawns()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnTime);
            SpawnDiscs();
        }
    }
}
