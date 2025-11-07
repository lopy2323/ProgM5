using UnityEngine;

public class Elf : Basicenemy
{
    void Start()
    {
        health = 50;
        speed = 5;
    }
    private void Update()
    {
        move();
    }
}

