using UnityEngine;
using System.Collections;

public class GoToHell : MonoBehaviour {
	private bool isRun = true;
	public float speed = 1;
    public AudioSource ambient;
	// Use this for initialization
	void Start () {
        StartCoroutine(GoToMainScene());
    }
	
	// Update is called once per frame
	void Update () {
		if (isRun) {
			Debug.Log(transform.position.y);
			transform.Translate (0, 0, Time.deltaTime * speed);
			speed += 0.001f;
		}
	}
	void OnCollisionEnter(Collision collision){
		if (collision.collider.tag == "ground") {
			isRun = false;
            
		} 
	}

    public IEnumerator GoToMainScene()
    {
        yield return new WaitForSeconds(17.5f);
        ambient.Stop();
        GetComponent<AudioSource>().enabled = true;

        yield return new WaitForSeconds(5);
        Application.LoadLevel("Main Scene");
    }
}
