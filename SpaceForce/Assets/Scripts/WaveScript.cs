using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveScript : MonoBehaviour

{
    Text wavenum;
   

    // Start is called before the first frame update
    void Start()
    {
        wavenum = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        wavenum.text = "Wave:" + winningCondition.army;
       
 
    }
}
