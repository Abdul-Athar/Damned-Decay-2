using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsFlicker : MonoBehaviour
{
    public Light lightOB;

    public AudioSource lightSound;

    public float minTime; // minimum random time that can selected
    public float maxTime; // maximum random time that can selected
    public float timer; // the time it takes to flicker on and off


    void Start()
    {
        timer = Random.Range(minTime, maxTime); // get a random number in between the min and max times.
    }

    void Update()
    {
        LightsFlickering();
    }

    void LightsFlickering()
    {
        if (timer > 0)
            timer -= Time.deltaTime; // this is so flicker time is in seconds and not in frames per second.

        if (timer <= 0)
        {
            lightOB.enabled = !lightOB.enabled;
            timer = Random.Range(minTime, maxTime);
            lightSound.Play();
        }



    }
}
