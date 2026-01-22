using UnityEngine;

public class DamageTrap : Collectable
{
    

    // Update is called once per frame
    public override void Collect()
    {
        HpScoreManager.HpChange.Invoke(-10);
        Debug.Log("BOOM!!");
    }
}
