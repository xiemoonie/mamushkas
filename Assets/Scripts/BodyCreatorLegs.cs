using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCreatorLegs : BodyCreator
{

    public Sprite[] Sprite_Legs;


    public override void Change()
    {
        rand = Random.Range(0, Sprite_Chest.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Legs[rand];
    }
}
