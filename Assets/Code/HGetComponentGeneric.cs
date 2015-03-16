using UnityEngine;
using System.Collections;

public class HGetComponentGeneric : MonoBehaviour {

public static T ByTag<T>(string tag)
{
	GameObject gameObject = GameObject.FindWithTag (tag);
	if (gameObject != null) 
	{
		return gameObject.GetComponent<T> ();		
	} 
	else 
	{
		Debug.Log ("Cannot find object with tag " + tag);
		return default(T);
	}
}

public static T ByName<T>(string name)
{
	GameObject gameObject = GameObject.Find(name);
	if (gameObject != null) 
	{
		return gameObject.GetComponent<T> ();
	} 
	else 
	{
		Debug.Log ("Cannot find object named" + name);
		return default(T);
	}
}

}
