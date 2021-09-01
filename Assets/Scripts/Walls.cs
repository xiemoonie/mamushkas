using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Walls : MonoBehaviour
{

    public HealthBar healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage;
    private int points;
    private Scene scene;

    public Image gameOver;
    public Image nextLevel;
   

    private int c;


    Color col;
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        scene = SceneManager.GetActiveScene();
       
      
        
      
    }

    // Update is called once per frame
    void Update(){
        //shows "gameOver"
         if(healthBar.slider.value <= 0){
           col = new Color(1,1,1,1);
           gameOver.color = col;
    

         for(int k = 0; k<100; k++){
               SceneManager.LoadScene(0);
              
          }
         }//NextLevel Sign
         if((points > 50) && (scene.name == "GameLv3")){
         col = new Color(1,1,1,1);
         nextLevel.color = col;
        
          for(int k = 0; k<100; k++){
           SceneManager.LoadScene(0);
         }
      }else if(points > 50){
         col = new Color(1,1,1,1);
         nextLevel.color = col;
         for(int k = 0; k<100; k++){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
         }
     
      }
     
   
    }
    
    
   

      void OnCollisionEnter2D(Collision2D collision){
        
                 if (collision.gameObject.tag == "Person") {
                      
                     
                      //c = bg.GetComponent<ColourPicker>().ReturnColor();
                      c = GameObject.Find("background").GetComponent<ColourPicker>().ReturnColor();
                      
                  
                      switch(c){
                      case 1 : 
                      if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name != "1"){
                        
                       currentHealth = currentHealth - damage;
                       healthBar.SetHealth(currentHealth);
                     
                       }
                       if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "1"){
                       points = points + 15;
                     
                       };
                        
                       break;
                      case 2 : 
                      if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name != "2"){

                      currentHealth = currentHealth - damage;
                      healthBar.SetHealth(currentHealth);
                    
                       }
                       if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "2"){
                       points = points + 15;
                
                       };
                       
                       
                       break;
                      case 3 : 
                      if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name != "3"){

                      currentHealth = currentHealth - damage;
                      healthBar.SetHealth(currentHealth);
                
                       }
                       if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "3"){
                       points = points + 15;
                   
                       };
                        
                       break;
                      case 4 : 
                      if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name != "4"){

                     currentHealth = currentHealth - damage;
                     healthBar.SetHealth(currentHealth);
                     
                     
                       }
                        if(collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name == "4"){
                       points = points + 15;
                       
                       };
                        
                       break;
                     
                    }
                  }     

                 }      
}
    