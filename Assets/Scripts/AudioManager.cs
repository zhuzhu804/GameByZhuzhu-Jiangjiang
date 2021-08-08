using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    // ²¥·Å×é¼þ
    private AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        player = GetComponent<AudioSource>();
    }

    public void Play(string name)
    {
        AudioClip clip = Resources.Load<AudioClip>(name);
        player.PlayOneShot(clip);
    }

}
