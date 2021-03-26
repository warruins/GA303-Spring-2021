using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// FIXME: With tay, show how to make this accessible throughout app for ease of use (in CustomGameSettings)
public enum Profession
{
    Alchemy,
    Blacksmithing,
    Enchanting,
    Tailoring
}

public enum ItemType
{
    Material,
    Craftable,
    Reagent,
    Recipe,
    Quest
}

public enum ItemQuality
{
    Junk,
    Common,
    Uncommon,
    Rare,
    Null
}

public abstract class ItemObj : ScriptableObject
{
    // TODO: with tay, share easy practice to make good, custom ids
    private void OnEnable()
    {
        itemId = Random.Range(1001, 9999);
    }
    

    public string itemName;
    public Sprite itemIcon;
    public Profession profession;
    public ItemType itemType;

    [TextArea(5, 10)]
    public string itemDescription;
    public int itemId;
}


//create method to gen id from iType
