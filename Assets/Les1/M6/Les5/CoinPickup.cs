using UnityEngine;

public class CoinPickup : Collectable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Collect()
    {
        HpScoreManager.ScoreChange.Invoke(10);
        Debug.Log("Coin collected!");
    }
}
