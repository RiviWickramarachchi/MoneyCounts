using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_over_screen : MonoBehaviour
{
    public void set_gameOver_screen()
    {
        gameObject.SetActive(true);
    }

    public void try_again_btn()
    {
        SceneManager.LoadScene("demoScene");
    }
}
