using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NonUISummonChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{

		if (Input.GetKeyDown (KeyCode.Mouse0)){
			Debug.Log ("Clicked");
			if (GameController.Instance.IsCorrectItemSummonned()) {
				SceneManager.LoadScene ("headpatscene");
			}
		}
	}
}
