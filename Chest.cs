using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int goldAmount = 5;

    protected override void OnCollect()
    {
        if(!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Found" + goldAmount + "gold!");
        }
        // collected = true == base.OnCollect();
        base.OnCollect();
        Debug.Log("Grant Gold");
    }
}
