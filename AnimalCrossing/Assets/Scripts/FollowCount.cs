using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FollowCount : MonoBehaviour
{
    public int followCount = 0;
    public TextMeshProUGUI followers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followers.text = (followCount).ToString("0");
    }
}
