using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public bool correctitemsummoned = false;

	void Awake() {
		if (Instance != null) {
			Destroy (gameObject);
		} else {
			Instance = this;
			DontDestroyOnLoad (this);
		}
	}

	public void SetSummon(bool summon_state) {
		Debug.Log ("Summon set to " + summon_state);
		correctitemsummoned = summon_state;
	}

	public bool IsCorrectItemSummonned () {
		return correctitemsummoned;
	}
}
