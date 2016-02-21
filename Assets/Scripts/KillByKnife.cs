using UnityEngine;
using System.Collections;

public class KillByKnife : MonoBehaviour {
	public bool isActive = false;
	public float speed = 30f;
	public float seconds = 4f;
	// Use this for initialization
	void Start () {
		StartCoroutine (doSome());
	}
	
	// Update is called once per frame
	void Update () {
		if (isActive) {
			transform.Translate (0f, -Time.deltaTime*speed, 0f);
		}
		if (transform.position.x < -20) {
			Destroy (gameObject);
		}
	}
	public IEnumerator doSome(){
		isActive = false;
		yield return new WaitForSeconds (seconds);
        GetComponent<AudioSource>().enabled = true;
		isActive = true;
	}
}
