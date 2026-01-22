using System;
using UnityEngine;

public class HpScoreManager : MonoBehaviour
{
    public static Action<int> HpChange;
    public static Action<int> ScoreChange;

    public static Action<int> HpChanged;
    public static Action<int> ScoreChanged;


    private int _Hp = 10;
    private int _Score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HpChange += HpchangeMAN;
        ScoreChange += ScorechangeMAN;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void HpchangeMAN(int value)
    {
        _Hp += value;
        HpChanged?.Invoke(_Hp);

        Debug.Log("Hp changed to: " + _Hp);
    }
    private void ScorechangeMAN(int value)
    {
        _Score += value;
        ScoreChanged?.Invoke(_Score);
    }
}
