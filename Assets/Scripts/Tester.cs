using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField] QuestionCode questionCode;
    private void Start()
    {
        questionCode.Hoge();
    }
}
