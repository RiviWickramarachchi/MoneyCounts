using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note_movement : MonoBehaviour
{
    bool allow_to_be_moved;
    Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.dragNote();
    }

    public void dragNote()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    allow_to_be_moved = true;
                }
            }

            if (touch.phase == TouchPhase.Moved)
            {
                if (allow_to_be_moved == true)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }

            if (touch.phase == TouchPhase.Ended)
            {
                allow_to_be_moved = false;
                
            }
        }
    }
}
