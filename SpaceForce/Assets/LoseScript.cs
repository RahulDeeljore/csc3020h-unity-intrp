using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{
    Text lose;

    // Start is called before the first frame update
    void Start()
    {
        lose = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
         // 2 lives for multiplayer, 1 for single player
        if( menu.life == 0)
        {
            lose.text = "GAMEOVER";
        }

    }
}
