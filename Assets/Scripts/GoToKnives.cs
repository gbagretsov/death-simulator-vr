using UnityEngine;
using System.Collections;

public class GoToKnives : MonoBehaviour
{
    public GameObject knivesRoom;
    public float speed = 2f;
    private bool stepFirst = true;
    private bool stepSecond = false;
    private Vector3 target;
    void Start()
    {
        target = transform.position;
        target.z -= 4f;
    }

    // Update is called once per frame
    void Update()
    {
        if (stepFirst)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                stepFirst = false;
                stepSecond = true;
                target.x -= 6;
            }
        }

        if (stepSecond)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                var knifes = GameObject.FindGameObjectsWithTag("Knife");
                knifes[0].GetComponent<KillByKnife>().enabled = true;
                knifes[1].GetComponent<KillByKnife>().enabled = true;
                knifes[2].GetComponent<KillByKnife>().enabled = true;
                knifes[3].GetComponent<KillByKnife>().enabled = true;
                knifes[4].GetComponent<KillByKnife>().enabled = true;
                GetComponent<AudioSource>().Stop();
                GetComponent<AudioSource>().enabled = false;
                knivesRoom.GetComponent<AudioSource>().enabled = true;
                StartCoroutine(Restart());
            }
        }
    }
    
    public IEnumerator Restart()
    {
        yield return new WaitForSeconds(12.3f);
        GetComponent<PlayerDeath>().enabled = true;
    }
}