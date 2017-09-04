using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDestroy : MonoBehaviour {
	public bool isPlayer = true;
	
	private void OnDestroy() {
		if (!Data.isGameOver){
			if (isPlayer) { // plyer
				Data.isGameOver = true;
				Data.isComplate = false;
				Debug.Log("Player Lost");
			} else { // enemy 
				Data.isGameOver = true;
				Data.isComplate = true;
				Debug.Log("Player Win");
			}
		}
	}
}
