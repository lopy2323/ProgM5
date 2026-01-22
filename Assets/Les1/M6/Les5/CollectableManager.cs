using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;
public class CollectableManager : MonoBehaviour
{
    public static Action OnCollectableCollected;

    List<Collectable> collectables = new List<Collectable>();

    private Collectable[] items;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnCollectableCollected += removeCollectable;

        items = FindObjectsByType<Collectable>(FindObjectsSortMode.None);
        foreach (var item in items)
        {
            collectables.Add(item);
        }
        Debug.Log("Collected items: " + collectables.Count);
    }

    // Update is called once per frame

    private void removeCollectable()
    {
        collectables.RemoveAt(0);
        Debug.Log("Collected items: " + collectables.Count);
    }
}
