using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCode : MonoBehaviour
{
    [SerializeField] Text taskText;
    private void Hoge()
    {
        taskText.text = "CLEAR";
    }
}
