using UnityEngine;
using System.Collections;

public class PersistentSingleton : MonoBehaviour {

	private static PersistentSingleton _instance;

	public static PersistentSingleton instance
	{
		get
		{
			if(_instance==null)
			{
				_instance = GameObject.FindObjectOfType<PersistentSingleton>();
				DontDestroyOnLoad(_instance.gameObject);
			}
			return _instance;
		}
	}


	void Awake()
	{
		if (_instance == null) 
		{
			_instance=this;
			DontDestroyOnLoad(this);
		}
		else
		{
			if(this != _instance)
				Destroy(this.gameObject);
		}
}
}