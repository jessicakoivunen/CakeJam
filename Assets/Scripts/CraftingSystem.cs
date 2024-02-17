using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CraftingSystem : MonoBehaviour
{
    public Inventory inventory;

    // Define the crafting recipe
    public GameObject ingredient1Prefab;  // Replace with the actual prefab for item 1
    public GameObject ingredient2Prefab;  // Replace with the actual prefab for item 2
    public GameObject ingredient3Prefab;  // Replace with the actual prefab for item 3

    public GameObject resultPrefab;  // Replace with the actual prefab for the crafted item

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        // Check for crafting conditions (e.g., when a button is pressed)
        if (Input.GetKeyDown(KeyCode.C))
        {
            Craft();
        }
    }

    void Craft()
    {
        // Check if both itemA and itemB are in the inventory
        int itemACount = CountItemsInInventory(ingredient1Prefab);
        int itemBCount = CountItemsInInventory(ingredient2Prefab);
        int itemCCount = CountItemsInInventory(ingredient3Prefab);


        if (itemACount >= 1 && itemBCount >= 1)
        {
            // Remove the required items from the inventory
            RemoveItemFromInventory(ingredient1Prefab);
            RemoveItemFromInventory(ingredient2Prefab);
            RemoveItemFromInventory(ingredient3Prefab);

            // Add the crafted item to the inventory
            AddItemToInventory(resultPrefab);
        }
    }

    int CountItemsInInventory(GameObject item)
    {
        int count = 0;
        foreach (GameObject slot in inventory.slots)
        {
            if (slot.transform.childCount > 0 && slot.transform.GetChild(0).gameObject == item)
            {
                count++;
            }
        }
        return count;
    }

    void RemoveItemFromInventory(GameObject item)
    {
        foreach (GameObject slot in inventory.slots)
        {
            if (slot.transform.childCount > 0 && slot.transform.GetChild(0).gameObject == item)
            {
                Destroy(slot.transform.GetChild(0).gameObject);
                break; // Assuming each item can only appear once in the inventory
            }
        }
    }

    void AddItemToInventory(GameObject item)
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                // Add the crafted item to an empty slot in the inventory
                inventory.isFull[i] = true;
                Instantiate(item, inventory.slots[i].transform, false);
                break;
            }
        }
    }
}

