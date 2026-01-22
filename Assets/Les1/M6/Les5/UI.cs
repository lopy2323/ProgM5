using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _coin;
    [SerializeField]private TextMeshProUGUI _HP;


    void Start()
    {
        HpScoreManager.HpChanged += UpdateHp;
        HpScoreManager.ScoreChanged += UpdateScore;

        startingValues();
    }
    void UpdateHp(int hp)
    {
        _HP.text = "HP: " + hp;
    }
    void UpdateScore(int score)
    {
        _coin.text = "Score: " + score;
    }
    private void startingValues()
    {
        UpdateHp(10);
        UpdateScore(0);
    }
}
