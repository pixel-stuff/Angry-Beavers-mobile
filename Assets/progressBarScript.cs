using UnityEngine;
using System.Collections;

public class progressBarScript : MonoBehaviour {

	public GameObject startAnchor;
	public GameObject progressBar;

	public float totalSize;
	public float progressBarSize;

	public float progressSpeed;

	public float progress;

	// Use this for initialization
	void Start () {
		progress = 0;
	}
	
	// Update is called once per frame
	void Update () {
		progress += progressSpeed;

		float xStartAnchor = startAnchor.transform.position.x;
		float percentProgress = progress / 100f;

		float progressSize = totalSize * percentProgress;


		float centerPosition = xStartAnchor+progressSize/2;
		progressBar.transform.position = new Vector3 (centerPosition, progressBar.transform.position.y, progressBar.transform.position.z);


		float scale = progressSize / progressBarSize;
		progressBar.transform.localScale = new Vector3 (scale, progressBar.transform.localScale.y, progressBar.transform.localScale.z);
	}
}
