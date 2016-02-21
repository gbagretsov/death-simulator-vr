using UnityEngine;
using System.Collections;

public class Flickering : MonoBehaviour
{

    public float Timer; //отсчитывает промежуток времени, через который мерцание
    public float inten;
    private float constIntens = 2;

    // Use this for initialization
    void Start()
    {
        //TimeDown = 1.0f;
        Timer = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Light>().intensity != constIntens)
            gameObject.GetComponent<Light>().intensity = constIntens;

        if (Timer > 0)
            Timer -= Time.deltaTime;

        if (Timer < 0)
            Timer = 0;

        if (Timer == 0)
        {
            inten = Random.Range(0.2f, 4.0f);
            gameObject.GetComponent<Light>().intensity = inten;
            Timer = Random.Range(0.2f, 0.6f);
        }
    }
}

