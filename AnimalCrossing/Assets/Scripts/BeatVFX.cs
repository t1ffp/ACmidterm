using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatVFX : MonoBehaviour
{
    public Animator hitAnim;
    public GameObject hitVFX;
    public GameObject beatDetector;

    // Start is called before the first frame update
    void Start()
    {
        hitAnim = GetComponent<Animator>();
        hitVFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (beatDetector.GetComponent<BeatDetector>().isHit)
        {
            hitVFX.SetActive(true);
            //hitAnim.SetBool("isPlaying", true);
        }
        else
        {
            hitVFX.SetActive(false);
            //hitAnim.SetBool("isPlaying", false);
        }
    }
}
