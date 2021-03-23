using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    public float quiz1;
    public float quiz2;
    public float quiz3;
    public float quiz4;
    public float quiz5;
    public float minGrade = 0.0f;
    public float maxGrade = 100.0f;


    // Start is called before the first frame update
    void Start()
    {
        
        quiz1 = Random.Range(minGrade, maxGrade);
        quiz2 = Random.Range(minGrade, maxGrade);
        quiz3 = Random.Range(minGrade, maxGrade);
        quiz4 = Random.Range(minGrade, maxGrade);
        quiz5 = Random.Range(minGrade, maxGrade);

        float quizAverage = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

        Debug.Log("The scores are: " + "Quiz1: " + quiz1 + " Quiz2: " + quiz2 + " Quiz3: " + quiz3 + " Quiz4: " + quiz4 + " Quiz5: " + quiz5);
        Debug.Log("The average score is: " + quizAverage);
    }

}
