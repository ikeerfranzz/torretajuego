using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text texto;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texto.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SumarPuntos(int puntos)
    {
        score += puntos;
        texto.text = "Score: " + score;
    }
}
