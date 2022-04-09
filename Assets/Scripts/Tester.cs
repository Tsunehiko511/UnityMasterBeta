using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    private void Start()
    {
        GameObject questionCodeObj = GameObject.Find("HUHUHUHUHU");
        QuestionCode questionCode = questionCodeObj.GetComponent<QuestionCode>();
        questionCode.Hoge();
    }
}
