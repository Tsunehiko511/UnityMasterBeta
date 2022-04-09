using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionCode : MonoBehaviour
{
    [SerializeField] Text text;

    private void Start()
    {
        text.text = "StudioShimazu最高！！！";
    }
}
