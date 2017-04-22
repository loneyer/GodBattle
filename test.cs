using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DCAgent.getInstance().initWithAppIdAndChannelId("468A028FD4E34D8C6B29584F67302E03", "1001");

		DCEvent.onEvent ("SignInTab_Btn");

		StartCoroutine (showLog ());
	}

	IEnumerator showLog(){
		yield return null;

		DCEvent.onEvent ("showLog");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
