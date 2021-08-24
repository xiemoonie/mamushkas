using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Movimiento: MonoBehaviour
{
     private GameObject auxhead;
     public GameObject bg;
   
     private int i;
 
     public int currentHealth;
     public int maxHealth = 100;

     public bool band = true;
     public ColourPicker cp;
     private int c;


     private AudioSource m_MyAudioSource;
     public float max;
     public float min;

     private float speed;




          public void RandomValue(){
               speed = Random.Range(min,max);
                
          }

       
          

          void Update() {
             
               if(band == true){
                transform.Translate(Vector2.left * Time.deltaTime*speed, Space.World);
                
               }else{
                transform.Translate(Vector2.right * Time.deltaTime*speed, Space.World);
               }
          }
        
                 
         
          void OnEnable(){
               i = 1;
               m_MyAudioSource = GetComponent<AudioSource>();
              
          
               if(transform.position.x == 25){
                    band = true;
               }else{
                    band = false;
               }
               
              
               RandomValue();
               
          }
    
         

          void OnCollisionEnter2D(Collision2D collision){
           if (collision.gameObject.tag == "Person"){
                 
           Physics2D.IgnoreCollision( collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
           }
           if (collision.gameObject.tag == "Wall"){
                   /*    
                     
                     c = bg.GetComponent<ColourPicker>().ReturnColor();
                      c = GameObject.Find("background").GetComponent<ColourPicker>().ReturnColor();
               
                  
                      switch(c){
                      case 1 : 
                      if(this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "1"){
                        
                        currentHealth = currentHealth - 10;
                       
                       }; 
                       break;
                      case 2 : 
                      if(this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "2"){

                       currentHealth = currentHealth - 10;
                       }; 
                       break;
                      case 3 : 
                      if(this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "3"){

                      currentHealth = currentHealth - 10;
                       }; 
                       break;
                      case 4 : 
                      if(this.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "4"){

                      currentHealth = currentHealth - 10;
                     
                       }; 
                       break;
                      }  */
                        this.transform.GetChild(0).localScale = new Vector3(1,1,1);
                    
                        this.gameObject.SetActive (false);

                    
                     
                          }
                    
                                }

         void OnMouseOver(){
                
                         if((gameObject.tag == "Person")&& (Input.GetMouseButtonDown(0))) {
                         m_MyAudioSource.Play();
                         if(i<4){
                         auxhead = transform.GetChild(0).gameObject;
                         auxhead.GetComponent<SpriteRenderer>().sprite = auxhead.GetComponent<CharacterCreator>().Sprite_Chest[i++];
                         auxhead.transform.localScale -= new Vector3(0.1f,0.1f,0f);
                         auxhead.transform.localPosition += new Vector3(0,-0.3f,0);
                         }
                         
                         if(band == false){
                         band = true;
                         }else{
                         band = false;
                         }


                          }
                        
   
               }


  }

                

     





