using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCode : MonoBehaviour
{
    [SerializeField] Text taskText;
    public void Start()
    {
        taskText.text = "CLEAR";
    }
}
