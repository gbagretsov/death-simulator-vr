using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public Collider playerCollider;
    public GameObject player;
    private bool isClosing = false;
    public GameObject door;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (door.transform.eulerAngles.y > 262)
            isClosing = false;
        if (isClosing)
        {
            door.transform.Rotate(new Vector3(0, 1, 0) * 10 * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (playerCollider == collider)
        {
            playerCollider.enabled = false;
            this.GetComponent<Collider>().enabled = false;
            player.GetComponent<AudioSource>().enabled = false;
            this.GetComponent<AudioSource>().enabled = true;
            isClosing = true;
            StartCoroutine(StartWalls());
        }
    }

    IEnumerator StartWalls()
    {
        var walls = GameObject.FindGameObjectsWithTag("Spikes Wall");

        yield return new WaitForSeconds(5);
        
        walls[0].GetComponent<WallMove>().enabled = true;
        walls[1].GetComponent<WallMove>().enabled = true;

        yield return new WaitForSeconds(20);

        player.GetComponent<PlayerDeath>().enabled = true;
    }
}
