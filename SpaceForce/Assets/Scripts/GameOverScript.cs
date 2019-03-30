using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour

   
{
    public static Text gameover;
    // Start is called before the first frame update
    void Start()
    {
        gameover = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (winningCondition.army == 0)
        {
            gameover.text = "You Win!";
        }

        
    }
}
