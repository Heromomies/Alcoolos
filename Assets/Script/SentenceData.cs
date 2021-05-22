using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentenceData : ScriptableObject
{
	public string name;
	
	[TextArea(5, 15)] 
	public string sentence;
}
