﻿using UnityEngine;
using System.Collections;

public class Wizard : MonoBehaviour {
	//Generic Wizard 

	public enum WizardStandState{
		OnSafe,
		OnDanger
	};

	//This File include the vars of the wizard class
	public int health;
	public int strength;
	public WizardStandState standState;
	
	private bool damaging = false;


	//Continously damaged if the player is stand on Fire
	void FixedUpdate (){

		if (standState == WizardStandState.OnDanger && !damaging){
			damaging = true;
			
			StartCoroutine(DangerDamage());
			
		}
		// reset the onDanger 


	}
	//Damage player with the Damage Interval and damage health point
	//This two parameter should be controled by outer script
	IEnumerator DangerDamage(){
		yield return new WaitForSeconds(1.0f);
		if (standState == WizardStandState.OnDanger) {
			health--;
		}
		damaging = false;
	}
}
