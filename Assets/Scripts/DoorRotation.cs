using UnityEngine;
using System.Collections;

public class DoorRotation : MonoBehaviour {

    public float Speed;
    private Vector3 Direction = new Vector3(0, -1, 0);
    private bool isMoving = true;
    public Collider doorCollider;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
            transform.Rotate(Direction * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider == doorCollider) isMoving = false;
    }

}
