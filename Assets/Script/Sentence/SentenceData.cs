using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue Data", menuName = "Dialogue Data")]
public class SentenceData : ScriptableObject
{
	public string name;
	
	[TextArea(5, 15)] 
	public string sentence;
}
