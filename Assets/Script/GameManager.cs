using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   // public SentenceData sentenceData;
    public TextMeshProUGUI text;
    public SentenceData sd;
    public void Start()
    {
	    text.text = sd.sentence;
	    
    }
}
