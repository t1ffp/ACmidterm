using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScoller : MonoBehaviour
{
    public float beatBPM;
    public bool isPlaying = false;
    public float beatSpeed;

    // Start is called before the first frame update
    void Start()
    {
        beatBPM = beatBPM / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
        {
            if (Input.anyKeyDown)
            {
                isPlaying = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatBPM * Time.deltaTime * beatSpeed, 0f);
        }
    }
}
