using UnityEngine;

public class HealthPickup : Collectable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public override void Collect()
    {
        HpScoreManager.HpChange.Invoke(10);
        Debug.Log("Health restored!");
    }
}

