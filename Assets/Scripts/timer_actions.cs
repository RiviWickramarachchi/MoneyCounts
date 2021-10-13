using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_actions : MonoBehaviour
{
    public float starting_time = 10f;
    public float current_time = 0f;
    [SerializeField] Text countDownText;
    public game_over_screen gameOverScreen;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {

        current_time = starting_time;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == false)
        {
            current_time -= 1 * Time.deltaTime;
            countDownText.text = current_time.ToString();
            print(current_time);
        }
        
        if(current_time <= 0)
        {
            //gameOvER ACTIONS
            
            countDownText.text = "0.00";
            gameOver = true;
            gameOverScreen.set_gameOver_screen();
        }
    }


}
