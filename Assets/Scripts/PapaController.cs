using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapaController : MonoBehaviour
{
    [Header("General")]
    [SerializeField]
    private float speed = 0f;
    private float basespeed = 10f;
    public GameObject model;

    [Header("Scream")]
    [SerializeField]
    private int stacks = 1;
    [SerializeField] [Tooltip("Cooldown based on game clock.")]
    private int hours = 2;
    private static AudioClip screamAudio;
    private AudioSource audioSrc; 


    // Start is called before the first frame update
    void Start()
    {
        speed = basespeed;
        screamAudio = Resources.Load<AudioClip>("papaScream");
        audioSrc = GetComponent<AudioSource>();
        Scream();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Scream(){
        audioSrc.PlayOneShot(screamAudio);
        stacks++;
        speed = basespeed*stacks;
    }

}
