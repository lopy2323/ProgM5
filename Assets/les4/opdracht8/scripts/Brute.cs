using UnityEngine;

public class Brute : Basicenemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1;
        health = 200;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
}
