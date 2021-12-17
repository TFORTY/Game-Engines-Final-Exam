using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject duckPrefab;
    public float respawnTime = 1f;

    Vector2 screenBounds;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(duckWave());
    }

    private void SpawnDuck()
    {
        Vector2 pos = new Vector2(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));

        var duck = ObjectPool.Instance.GetFromPool();
        duck.transform.position = pos;

        //GameObject a = Instantiate(duckPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    /*public IEnumerator duckWave()
    {
        // Spawns planets at every interval
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnDuck();
        }
    }*/
}