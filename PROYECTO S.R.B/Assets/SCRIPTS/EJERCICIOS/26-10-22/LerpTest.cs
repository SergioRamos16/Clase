using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    public float a = 0;
    public float b = 10;

    public float timeToLerp = 5;
    private float timeElapsed = 0;

    public float lerpValue;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        float lerpPercentage = timeElapsed / timeToLerp;

        lerpValue = Mathf.Lerp(a, b, lerpPercentage);
    }
}