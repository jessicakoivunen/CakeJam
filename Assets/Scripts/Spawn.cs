using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        soundManager.soundManagement.playSound(0);
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2 (player.position.x, player.position.y);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
