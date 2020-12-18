using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    // text boxs
    [SerializeField]
    static Text score_text;
    [SerializeField]
    static Text coins_text;
    int score = 0;
    static int monedas = 0;

    // Start is called before the first frame update
    void Start()
    {
        score_text = GameObject.Find("Score").GetComponent<Text>();
        coins_text = GameObject.Find("Monedas").GetComponent<Text>();
        score_text.text = "Score: " + score;
        coins_text.text = "Monedas: " + monedas;
    }

    // Update is called once per frame
    void Update()
    {
        AddScore(1);
        
    }

    public void AddScore(int points)
    {
        score += points;
        score_text.text = "Score: " + score;
    }
    public static void AddMoneda(int points)
    {
        monedas += points;
        coins_text.text = "Monedas: " + monedas;
    }
}
