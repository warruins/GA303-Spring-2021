using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new Quest", menuName = "Game Systems/Quests")]
public class QuestData : ItemObj
{
    /*public void Awake()
    {

    }*/

    public enum RewardType
    {
        Currency,
        Reputation,
        Reagent
    }

    public int questObjective; // TODO: This is supposed to be a string, right? Or maybe an item object?
    public int invQuantity;

    public bool questTimed;
    public int questTimer;
    public bool questActive;
    public bool questComplete;

    public int rewardAmount;
    public Sprite rewardImage;
    public RewardType rewardType;
}



