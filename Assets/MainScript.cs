using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {
	public GameObject image;

	public float zoom;
	void Update(){
		if (Input.GetKeyDown (KeyCode.H))
			SetBinoView ();
		if (image.activeInHierarchy) {
			float d = Input.GetAxis("Mouse ScrollWheel");
			if (d > 0f && zoom<=30)
			{
				Camera.main.fieldOfView = zoom++;
			}
			else if (d < 0f && zoom>=10)
			{
				Camera.main.fieldOfView = zoom--;
			}
		}
	}

	public void SetBinoView(){
		if (!image.activeInHierarchy) {
			image.SetActive (true);
			zoom=Camera.main.fieldOfView = 24;
		} else {
			image.SetActive (false);
			Camera.main.fieldOfView = 60;
		}
	}
}
