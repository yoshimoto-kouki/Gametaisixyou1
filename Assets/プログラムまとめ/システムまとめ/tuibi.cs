using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuibi : MonoBehaviour
{
    GameObject player;


    void Start()
    {
        this.player = GameObject.Find("player");
    }
    void Update()
    {
        Vector2 playerPos = this.player.transform.position;
        float ENEMY_MOVE_SPEED = 0.01f;
        transform.position = Vector2.MoveTowards(transform.position, playerPos,ENEMY_MOVE_SPEED);
    }
}