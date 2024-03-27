using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab; // Prefab for the note object
    public float bpm = 120; // Beats per minute
    public float offset = 0; // Time offset for note spawning

    private float beatInterval; // Duration of each beat in seconds
    private float nextSpawnTime; // Time to spawn the next note

    void Start()
    {
        // Calculate beat interval from BPMs
        beatInterval = 60f / bpm;

        // Set initial spawn time
        nextSpawnTime = Time.time + offset;
    }

    void Update()
    {
        // Spawn a note if it's time
        if (Time.time >= nextSpawnTime)
        {
            SpawnNote();
            nextSpawnTime += beatInterval; // Update next spawn stime
        }
    }

    void SpawnNote()
    {
        // Instantiate the note object at the desired position
        Instantiate(notePrefab, transform.position, Quaternion.identity);
    }
}
