using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public bool start;
    [SerializeField] TMP_Text watch;
    float value = 0;

    public void SetBool(bool val)
    {
        start = val;
    }

    public void Reset()
    {
        start = false;
        value = 0;
    }

    private void Update()
    {
        if (start == false)
            return;

        value += Time.deltaTime;
        double b = System.Math.Round(value, 1);
        watch.text = b.ToString();
    }
}
