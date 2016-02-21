using UnityEngine;
using System.Collections;

public class GoToSpikes : MonoBehaviour
{
    public float speed = 2f;
    private bool stepFirst = true;
    private bool stepSecond = false;
    private Vector3 target;
    void Start()
    {
        target = transform.position;
        target.z += 3;
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
                target.x += 8;
            }
        }

        if (stepSecond)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                
            }
        }
    }
}

