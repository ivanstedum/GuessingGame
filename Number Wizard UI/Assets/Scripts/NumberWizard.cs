using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI numberGuess;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    

    void StartGame()
    {
        
        NextGuess();
       

    }
    public void onPressHigher()
    {
        min = guess;
        NextGuess();
    }
    public void onPressLower()
    {
        max = guess;
        NextGuess();
    }
    // Update is called once per frame

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        numberGuess.text = guess.ToString();

    }
}
