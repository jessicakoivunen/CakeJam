using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private float pickupDelay = 1f;
    public GameObject particle;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (pickupDelay > 0)
        {
            pickupDelay -= Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && pickupDelay <= 0) {
            for (int i = 0; i < inventory.slots.Length; i++) {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);

                    GameObject puff = Instantiate(particle, transform.position, quaternion.identity);
                    puff.transform.parent = null;
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
