using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCode : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Text clearText;

    private void Update()
    {
        if (text.text == "StudioShimazu")
        {
            clearText.text = "CLEAR";
        }
    }
}
