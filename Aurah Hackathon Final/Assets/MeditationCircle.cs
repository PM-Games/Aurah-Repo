using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeditationCircle : MonoBehaviour
{
    //fade audio in and out

    [SerializeField] AudioSource source;

    [SerializeField] float vol;

    public void FadeOut()
    {
        source.volume = Mathf.Lerp(vol, 0, 3*Time.deltaTime);
    }

    public void FadeIn()
    {
        source.volume = Mathf.Lerp(0, vol, 3 * Time.deltaTime);
    }
}
