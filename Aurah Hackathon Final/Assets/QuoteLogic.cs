using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuoteLogic : MonoBehaviour
{
    //create a list of strings that we can modify from the editor itself
    [SerializeField] List<string> quotes = new List<string>();

    //grab the quote text holder and store it in a referenced variable
    [SerializeField] TMP_Text quoteText;

    //find the quote number the user is currently on
    int count = 0;

    public void NewQuote()
    {
        //this checks if the user is on the last quote. if so, set the count to 0
        if (count == quotes.Count-1)
            count = 0;
        else
            count++;

        //create a new int to store the value
        int quote = count;

        //set the text to the referenced quote
        quoteText.text = quotes[quote].ToString();
    }
}
