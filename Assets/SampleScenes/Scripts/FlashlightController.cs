using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour {

	public Flashlight startingFlashlight;
	Flashlight equippedFlashlight;
	public Transform flashlightHold;

	int batteryLife;
	int damagePerSecond;
	float beamWidthAngle;

	// Use this for initialization
	void Start () {
		if (startingFlashlight != null) {
			EquipFlashlight (startingFlashlight);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EquipFlashlight(Flashlight flashlight) {
		if (equippedFlashlight != null) {
			Destroy (equippedFlashlight.gameObject);
		}
		flashlight = Instantiate(flashlight, flashlightHold.position, flashlightHold.rotation) as Flashlight;
		flashlight.transform.parent = flashlightHold;
    }


}
