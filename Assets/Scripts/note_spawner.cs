using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_spawner : MonoBehaviour
{
    public GameObject noteToSpawn;
    public Sprite[] noteSprites;
    List<GameObject> notesList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        

        for(int i=0;i <3; i++)
        {
          GameObject note =  spawnRandomNote();
          notesList.Add(note);
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        notesList[0].GetComponent<note_movement>().dragNote();
    } 
    
    public GameObject spawnRandomNote()  
    {
        
        int arrIndex = Random.Range(0, noteSprites.Length);
        Sprite noteSprite = noteSprites[arrIndex];
        string noteName = noteSprite.name;
       
        GameObject newMoneyNote = Instantiate(noteToSpawn);

        newMoneyNote.name = noteName;
        newMoneyNote.GetComponent<note>().noteVal = int.Parse(noteName);
        newMoneyNote.GetComponent<SpriteRenderer>().sprite = noteSprite;
        newMoneyNote.transform.position = new Vector3(-1.25f, 2.21f, 0);
        newMoneyNote.transform.localScale = new Vector3(0.5f, 1f, 1f);
        return newMoneyNote;
       
    }
}
