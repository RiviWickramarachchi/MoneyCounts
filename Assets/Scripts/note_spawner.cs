using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_spawner : MonoBehaviour
{
    public GameObject noteToSpawn;
    public Sprite[] noteSprites;
    //List<GameObject> notesList = new List<GameObject>();
    private int noteCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        

        for(int i=0;i <3; i++)
        {
          GameObject note =  spawnRandomNote();
            //notesList.Add(note);
            noteCount++;
          
        }
        print(noteCount);


        
    }

    // Update is called once per frame
    void Update()
    {


        //notesList[3].GetComponent<note_movement>().dragNote();
        

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
        newMoneyNote.transform.position = new Vector3(-2.9f, 19.1f, 0);
        newMoneyNote.transform.localScale = new Vector3(8f, 7f, 1f);
        newMoneyNote.tag = "Note";
        return newMoneyNote;
       
    }

    public int getNoteCount()
    {
        return noteCount;
    }

    

}
