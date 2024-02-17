using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Cake;
    public Sprite[] topping;
    public Sprite[] filling;
    public Sprite[] body;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");

        if (items.Length >= 3)
        {
            // Shuffle the items
            GameObject[] shuffledItems = ShuffleItems(new GameObject[] { items[0], items[1], items[2] });

            // Assign sprites and destroy objects in the shuffled order
            AssignSprite(shuffledItems[0], 0, topping);
            AssignSprite(shuffledItems[1], 1, filling);
            AssignSprite(shuffledItems[2], 2, body);

            Debug.Log(shuffledItems[0].name + shuffledItems[1].name + shuffledItems[2].name);

            Destroy(shuffledItems[0]);
            Destroy(shuffledItems[1]);
            Destroy(shuffledItems[2]);
        }
    }

    private GameObject[] ShuffleItems(GameObject[] items)
    {
        int n = items.Length;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            GameObject temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        return items;
    }


    private void AssignSprite(GameObject item, int childIndex, Sprite[] sprites)
    {
        int spriteIndex = -1; // Initialize to an invalid index

        switch (item.GetComponent<tag>().identifier)
        {
            case "Wood":
                spriteIndex = 0;
                break;
            case "Stone":
                spriteIndex = 1;
                break;
            case "Meat":
                spriteIndex = 2;
                break;
            case "Flour":
                spriteIndex = 3;
                break;
            case "Fish":
                spriteIndex = 4;
                break;
            case "Cream":
                spriteIndex = 5;
                break;
            case "Carrot":
                spriteIndex = 6;
                break;
            // Add similar cases for other identifiers

            default:
                Debug.LogError("Invalid identifier: " + item.GetComponent<tag>().identifier);
                break;
        }

        if (spriteIndex != -1)
        {
            Debug.Log(spriteIndex);
            Cake.transform.GetChild(childIndex).GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
        }
    }

}
