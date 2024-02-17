using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CraftingSystem : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Cake;
    public Sprite[] topping;
    public Sprite[] filling;
    public Sprite[] body;


    private void Start()
    {
        Item1 = GameObject.FindGameObjectsWithTag("Item")[0];
        Item2 = GameObject.FindGameObjectsWithTag("Item")[1];
        Item3 = GameObject.FindGameObjectsWithTag("Item")[2];

        if (Item1.name == "WoodItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[0];
        }
        else if (Item1.name == "StoneItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[1];
        }
        else if (Item1.name == "MeatItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[2];
        }
        else if (Item1.name == "FlourItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[3];
        }
        else if (Item1.name == "FishItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[4];
        }
        else if (Item1.name == "CreamItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[5];
        }
        else if (Item1.name == "CarrotItem")
        {
            Cake.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = topping[6];
        }

        if (Item2.name == "WoodItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[0];
        }
        else if (Item2.name == "StoneItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[1];
        }
        else if (Item2.name == "MeatItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[2];
        }
        else if (Item2.name == "FlourItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[3];
        }
        else if (Item2.name == "FishItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[4];
        }
        else if (Item2.name == "CreamItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[5];
        }
        else if (Item2.name == "CarrotItem")
        {
            Cake.transform.GetChild(1).GetComponent<SpriteRenderer>().sprite = filling[6];
        }

        if (Item3.name == "WoodItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[0];
        }
        else if (Item3.name == "StoneItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[1];
        }
        else if (Item3.name == "MeatItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[2];
        }
        else if (Item3.name == "FlourItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[3];
        }
        else if (Item3.name == "FishItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[4];
        }
        else if (Item3.name == "CreamItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[5];
        }
        else if (Item3.name == "CarrotItem")
        {
            Cake.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite = body[6];
        }

    }


   
}

