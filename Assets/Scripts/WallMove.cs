using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour {

    public float Speed;
    public Vector3 Direction;
    public bool isMoving = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
            transform.Translate(Direction * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider) 
    {
        isMoving = false;        
    }
}
