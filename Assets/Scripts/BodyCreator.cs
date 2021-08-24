using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCreator:MonoBehaviour
{
        public int rand;
        public Sprite[] Sprite_Chest;
        public int k;
    
     
    /*
    public static int generateRandomNumber(int min, int max) {
 
     int result = Random.Range(min, max);
 
     if(result == lastRandomNumber) {

 
             return generateRandomNumber(result, max);
 
     }
      
     lastRandomNumber = result;
     return result;
 
     }*/




    // Start is called  before the first frame update
    void Start()
    {
        rand = Random.Range(0, Sprite_Chest.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Chest[rand]; 
        Change();    
       
    }


    public void Change(){
        
        GetComponent<SpriteRenderer>().sprite = Sprite_Chest[rand];

        
        
    }

     public void Update()
    {
        
    }

}
