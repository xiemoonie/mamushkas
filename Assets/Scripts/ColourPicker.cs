using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColourPicker : MonoBehaviour
{
    private SpriteRenderer backgroundImg;
    public int col = 0;
    private Color c;

    // Start is called before the first frame update
    void Start()
    {

        backgroundImg = gameObject.GetComponent<SpriteRenderer>();
        col = Random.Range(1, 5);

        switch (col)
        {
            case 1: c = new Color(0, 1, 0, 1); break; //green
            case 2: c = new Color(1, 0, 0, 1); break; //red
            case 3: c = new Color(0, 0, 1, 1); break; //blue
            case 4: c = new Color(0.5f, 1, 1, 1); break; //skyblue


        }

        backgroundImg.color = c;

    }

    public int ReturnColor()
    {
        return col;
    }



}





