using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]private GameObject coin;
    List<GameObject> coins = new List<GameObject>();
    private float timer = 0f;
    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            spawn();
            timer = 0f;
        }
        if (coins.Count < 10)
        {
            for (int i = 0; i < 10; i++)
            {
                spawn();
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            for (int i = 0; i < coins.Count; i++)
            {
                    Destroy(coins[i]);
            }
            coins.Clear();
        }
        if (coins.Count > 20)
        { 
            for (int i = 0; i < coins.Count; i++)
            {
                Destroy(coins[i]);
            }
            coins.Clear();
        }
    }
    void spawn()
    {
        float x = Random.Range(-30,30);
        float z = Random.Range(-30,30);

        GameObject newCoin = Instantiate(coin, new Vector3(x,0,z), Quaternion.identity);
        coins.Add(newCoin);
    }
}
