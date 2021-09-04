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
    void Update()
    {
        //shows "gameOver"
        if (healthBar.slider.value <= 0)
        {
            col = Color.white;
            gameOver.color = col;


            for (int k = 0; k < 100; k++)
            {
                SceneManager.LoadScene(0);

            }
        }//NextLevel Sign
        if (points > 50)
        {
            if (scene.name == "GameLv3")
            {
                col = new Color(1, 1, 1, 1);
                nextLevel.color = col;

                for (int k = 0; k < 100; k++)
                {
                    SceneManager.LoadScene(0);
                }
            }
            else
            {
                col = new Color(1, 1, 1, 1);
                nextLevel.color = col;
                for (int k = 0; k < 100; k++)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }

            }
        }

    }




    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Person")
        {


            //c = bg.GetComponent<ColourPicker>().ReturnColor();
            c = GameObject.Find("background").GetComponent<ColourPicker>().ReturnColor();


            if (collision.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite.name != c.ToString())
            {
                currentHealth -= damage;
                healthBar.SetHealth(currentHealth);
            }
            else
            {
                points += 15;

            };


        }

    }
}
