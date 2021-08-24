using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject chestPrefab;
    public Sprite[] chestSprites;
  

    public void MakeRandomCharacter(){
    int arrayIdx = Random.Range(0,chestSprites.Length);
    Sprite chestSprite = chestSprites[arrayIdx];
    string characterName = chestSprite.name;
    
    GameObject newCharacter = Instantiate(chestPrefab, new Vector3(0,0,0), Quaternion.identity);
    newCharacter.name = characterName;
    newCharacter.GetComponent<Character>().name = characterName;
    newCharacter.GetComponent<SpriteRenderer>().sprite = chestSprite;





}

 }   