using System;
using UnityEngine;
using System.Collections.Generic;

public class coin : MonoBehaviour
{
    public static event Action <int>OnCoinCollected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int randomPoints = UnityEngine.Random.Range(1, 11);
            OnCoinCollected?.Invoke((randomPoints));
            Destroy(gameObject);
        }
    }
}
