using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuoteLogic : MonoBehaviour
{
    [SerializeField] List<string> quotes = new List<string>();

    [SerializeField] TMP_Text quoteText;

    int count = 0;

    public void NewQuote()
    {
        if (count == quotes.Count-1)
            count = 0;
        else
            count++;

        int quote = count;

        quoteText.text = quotes[quote].ToString();
    }
}
