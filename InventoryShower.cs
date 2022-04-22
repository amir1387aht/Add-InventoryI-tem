using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class InventoryShower : MonoBehaviour
{
    public Inventory inv;
    // Item Collected

    public GameObject Item;
    //item prefabs

    public Transform Contect;
    //Contact Of Scrollview

    public List<GameObject> imgs;
    //the list if items in scroll view

    private int count = 0;
    //last object

    public void AddItems()
    {
        for (int i = count; i < inv.Items.Count; i++)
        {
            GameObject img = Instantiate(Item, Contect);
            img.GetComponent<Image>().sprite = inv.Items[i].GetComponentInChildren<SpriteRenderer>().sprite;
            imgs.Add(img);
            count++;
        }
    }
}