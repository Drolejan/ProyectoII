using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    Collider2D area;
    void Start()
    {
        area=GetComponent<Collider2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(spawnEnemies());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StopAllCoroutines();
        }
    }

    IEnumerator spawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Vector2 spawnPos = new Vector2(Random.Range(area.bounds.min.x,area.bounds.max.x), Random.Range(area.bounds.min.y, area.bounds.max.y));
            Instantiate(enemy,spawnPos,Quaternion.identity);
        }
    }
}
