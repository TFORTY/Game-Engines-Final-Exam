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
    }

    private void SpawnDuck()
    {
        Vector2 pos = new Vector2(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));

        var duck = ObjectPool.Instance.GetFromPool();
        duck.transform.position = pos;

    }
}