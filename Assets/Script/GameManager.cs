using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SentenceData sentenceData;
    private string _name;
    
    public void ReadStringInput(string s)
    {
        _name = s;
        Debug.Log(s);
    }
}
