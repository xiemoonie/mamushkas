using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreator : MonoBehaviour
{

        public Sprite[] Sprite_Chest;
        private int i = 0;
    

 
    
        void Start()
         {
         for (var k = 0; k < Sprite_Chest.Length; k++) {
         var j = Random.Range(0,Sprite_Chest.Length);
         var go = Sprite_Chest[k];
         Sprite_Chest[k] = Sprite_Chest[j];
         Sprite_Chest[j] = go;
     }
        GetComponent<SpriteRenderer>().sprite = Sprite_Chest[0];

   
     }

      
    

    

    
    }


