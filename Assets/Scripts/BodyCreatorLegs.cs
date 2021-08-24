using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCreatorLegs : BodyCreator
{ 
    
     public Sprite[] Sprite_Legs;

    void Start()
    {
        rand = Random.Range(0, Sprite_Legs.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Legs[rand]; 
        Change();    
       
    }



    public void Change(){
        rand =  Random.Range(0,Sprite_Chest.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Legs[rand];

        
    }
}
