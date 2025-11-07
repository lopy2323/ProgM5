using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]private GameObject enemyPrefab;
    private List<GameObject> enemies = new List<GameObject>();
    float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                var eniems = Instantiate(enemyPrefab,transform.position, Quaternion.identity);
                enemies.Add(eniems);
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Destroy(enemies[i]);
            }
            enemies.Clear();
        }
        if (timer >= 1f)
        {
            timer = 0f;
            for (int i = 0; i < 3; i++)
            {
                var eniems = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemies.Add(eniems);
            }
        }
    }
}
