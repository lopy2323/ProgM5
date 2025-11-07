using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI text;
    private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coin.OnCoinCollected += points;
    }

    // Update is called once per frame
    void points(int point)
    {
        score +=  point;
        text.text = "coins: " + score;
    }
}
