using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI LeftPlayerScore;
    public TextMeshProUGUI RightPlayerScore;

    public void setleftplayerscore(string text)
    {
        LeftPlayerScore.SetText(text);
    }
    public void setrightplayerscore(string text)
    {
        RightPlayerScore.SetText(text);
    }




}
