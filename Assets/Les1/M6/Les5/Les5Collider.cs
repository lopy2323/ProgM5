using UnityEngine;
using System.Collections.Generic;
public class Les5Collider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collect"))
        {
            var col = other.GetComponent(typeof(Collectable)) as Collectable;
            col.Collect();
            CollectableManager.OnCollectableCollected?.Invoke();
            Destroy(other.gameObject);
        }
    }
}
