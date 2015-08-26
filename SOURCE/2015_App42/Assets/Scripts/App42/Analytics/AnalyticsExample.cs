using UnityEngine;
using System.Collections;
using com.shephertz.app42.paas.sdk.csharp;
using System.Collections.Generic;

public class AnalyticsExample : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		App42Analytics.Initialize ("Jorge Salvi");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.A)) {
			App42Analytics.TrackEvent ("EVENT_SINGLE", null, new DefaultCallBack ()); 
//			 
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Dictionary<string,object> properties = new Dictionary<string, object> ();  
			properties.Add ("gold", 555);  			 
			App42Analytics.TrackEvent ("EVENTPROPERTY", properties, new DefaultCallBack ()); 
		}
	}

	public class DefaultCallBack : App42CallBack
	{
		public void OnSuccess (object response)
		{
			Debug.Log ("Success: " + response.ToString());
		}
				
		public void OnException (System.Exception e)
		{
			Debug.Log ("CreateUser: Exception : " + e);
		}
	}
}
