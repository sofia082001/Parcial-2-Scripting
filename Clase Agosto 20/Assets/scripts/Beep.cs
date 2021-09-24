using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beep : MonoBehaviour
{
    [SerializeField] private eventControllerSO canal;

    [SerializeField] private AudioClip clip;

    private AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<AudioSource>();
        player.clip = clip;
    }


    // Update is called once per frame
    private void OnEnable()
    {
        canal.cambieColor += PlayBeep;
    }
    private void OnDisable()
    {
        canal.cambieColor -= PlayBeep;
    }
    public void PlayBeep()
    {
        player.Play();
    }
}
