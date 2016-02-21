using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

    public Canvas blood;
    public Image fade;
    public float fadeSpeed = .5f;
    private bool fading = false;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartDeath());
    }
	
	// Update is called once per frame
	void Update ()
    {
          if (fading)
                fade.color = Color.Lerp(fade.color, Color.black, fadeSpeed * Time.deltaTime);
    }

    IEnumerator StartDeath()
    {
        blood.enabled = true;
        yield return new WaitForSeconds(4);
        fading = true;
        yield return new WaitForSeconds(4.5f);
        Application.LoadLevel("Main Scene");
    }
}
