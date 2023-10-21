using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    //the start bool tells the code when to start the stopwatch
    public bool start;
    //this TMP_Text references the visual text which the user will see
    [SerializeField] TMP_Text watch;
    //the value is the time elapsed
    float value = 0;

    //once this function is called with the button, it will set the start value based on the parameter passed
    public void SetBool(bool val)
    {
        start = val;
    }

    //reset will allow the player to restart his focus session
    public void Reset()
    {
        start = false;
        value = 0;
    }

    private void Update()
    {
        if (start == false)
            return;

        //add time to the stopwatch
        value += Time.deltaTime;
        //round to 1 decimal place
        double b = System.Math.Round(value, 1);
        //set the text to the new string
        watch.text = b.ToString();
    }
}
