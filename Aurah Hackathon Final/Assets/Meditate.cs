using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meditate : MonoBehaviour
{
    //grab the animator linked to the main audio player
    //the animator controls the fade in/fade out by directly animating the volume value
    [SerializeField] Animator audioAnim;

    //Fade in function, which plays the fade in animation on the audio object
    public void FadeIn()
    {
        audioAnim.Play("FadeInAudio");
    }

    //Fade out function, which plays the fade out animation on the audio object
    public void FadeOut()
    {
        audioAnim.Play("FadeOutAudio");
    }
}
