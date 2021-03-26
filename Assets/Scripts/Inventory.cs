﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Game Systems/Inventory")]


public class Inventory : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>(); //list of items currently in the inventory
    
    public void AddItem(ItemObj _item, int _itemAmount)
    {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].item == _item)
            {
                Container[i].AddItem(_itemAmount);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            Container.Add(new InventorySlot(_item, _itemAmount));
        }
    }

   /* public string FindItem(int _itemId)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if (Container[i].itemId == _itemId)
            {
                return Container[i];
            }
        }
        return null;
    }*/

    [System.Serializable]
    public class InventorySlot //represents each ITEM held within the inventory
    {
        public ItemObj item;
        public int itemAmount;
        public int itemId;

        public InventorySlot(ItemObj _item, int _itemAmount) //what is the item and how many are there?
        {
            item = _item;
            itemAmount = _itemAmount;
        }

        public void AddItem(int value)
        {
            itemAmount += value;
        }
    }

    public InventorySlot FindItem(int item_id)
    {
        for(int i = 0; i < Container.Count; i++)
        {
            if(Container[i].itemId == item_id)
            {
                return Container[i];
            }
        } return null;
    }
}

