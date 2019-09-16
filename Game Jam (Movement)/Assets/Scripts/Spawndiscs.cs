using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This should go on Main Camera in Unity
//script which Spawns discs at points just outside of the screenbounds
//

public class Spawndiscs : MonoBehaviour{
    public GameObject discPrefab;//loads discPrefab into code
    public float SpawnTime = 0.8f;//Default spawn time
    private Vector2 screenBounds;//Finds screen size
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(DiscSpawns());
    }
    void Update() {
        GameObject scoretext = GameObject.Find("Score");
        string texttemp = scoretext.GetComponent<TextMesh>().text;
        string[] splitArray = texttemp.Split(char.Parse(" "));
        string temp2 = splitArray[0];
        string temp = splitArray[1];
        int tempnum = int.Parse(temp);

        if (tempnum >= 10000) {
            SpawnTime = 0.006f;
        }
        else if (tempnum >= 8000) {
            SpawnTime = 0.008f;
        }
        else if (tempnum >= 6000) {
            SpawnTime = 0.02f;
        }
        else if (tempnum >= 4000) {
            SpawnTime = 0.04f;
        }
        else if (tempnum >= 2000) {
            SpawnTime = 0.06f;
        }
        else if (tempnum >= 1000) {
            SpawnTime = 0.08f;
        }
        else if (tempnum >= 800) {
            SpawnTime = 0.2f;
        }
        else if (tempnum >= 600) {
            SpawnTime = 0.4f;
        }
        else if (tempnum >= 400) {
            SpawnTime = 0.6f;
        }
        else if (tempnum <= 200) {
            SpawnTime = 0.8f;
        }

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
