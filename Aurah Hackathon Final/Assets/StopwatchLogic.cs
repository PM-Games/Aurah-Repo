using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StopwatchLogic : MonoBehaviour
{
    public bool start;
    [SerializeField] TMP_Text watch;
    float value = 0;

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
        string.Format("{0:00.00}", value);
        watch.text = value.ToString();
    }
}
