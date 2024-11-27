using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrivialGamePlay : MonoBehaviour
{
    [SerializeField] ScriptableQuestion[] questions;    /*en este array se meten todas las preguntas*/
    [SerializeField] int questionIndex, rightAnswers;   /*QuestionIndex es número de pregunta por el que voy, y rightAnswers es el número de preguntas acertadas*/
    [SerializeField] Text questionIndexText, rightAnswersText;  /*Es lo mísmo de la línea de arriba, pero ya se ve en el juego*/
 
    [SerializeField] Text questionText;                 /*pregunta*/
    [SerializeField] Text[] answersText;                /*Textos de las respuestas*/

    // Start is called before the first frame update
    void Start()
    {
        ChangeQuestion();
    }


    void ChangeQuestion() 
    {
        questionIndex++;                           /*Va cambiando de pregunta sumando 1, empiezo en la pregunta -1, que +1 es igual a 0*/
        questionIndexText.text = "Pregunta: " + questionIndex + "/20";     /*Pregunta 1/10, luego 2/10.....*/
        if (questionIndex >= 20) 
        {
            GameOverManager.gameOverManager.InitializeGameOver(); 
        }
          /*Va volcando a la escena la información del scriptableObject*/
        questionText.text = questions[questionIndex].questionTitle;
        
        for(int i=0; i < answersText.Length; i++) 
        {
            answersText[i].text = questions[questionIndex].answers[i];     /*Pone las respuéstas que correspenden a cada pregunta*/
        }
    }
    
    public void CheckAnswer(int n)   /*Sirve para chequear las respuéstas y ver si sin correctas*/
    {
        if (n == questions[questionIndex].rightAnswer) 
        {
           
            rightAnswers++;
            rightAnswersText.text = "Acertadas: " + rightAnswers;
          
        }
        ChangeQuestion();
    }
}
