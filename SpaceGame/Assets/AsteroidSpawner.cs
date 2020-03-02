using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Vector3[] spawnPos;
    public float spawnInterval = 1;
    public float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if( timer >= spawnInterval)
        {
            // Generates a random index to remove from our wave
            int e = Random.Range(0, spawnPos.Length);
            List<GameObject> wave = new List<GameObject>();
            for(int i = 0; i < spawnPos.Length; i++)
            {
                GameObject asteroid = Instantiate<GameObject>(asteroidPrefab, spawnPos[i], Quaternion.identity);
                asteroid.name = "Asteroid";
                wave.Add(asteroid);
            }
            // Gets asteroid that needs to be removed and makes it invisible
            wave[e].GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            // Changes the name of gameObject for collision code
            wave[e].name = "Points";

            // resets spawn timer
            timer = 0;

            // Varies the spawn interval between 1.5 seonds and 2 seconds
            spawnInterval = Random.Range(1.5f, 2f);
        }
    }
}
