using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text pointsText;
    public void AddPoints()
    {
        scoring.totalScore += 10;
    }
    public void GetPoints()
    {
        int recievedPoints =0;
        pointsText.text = recievedPoints.ToString();
    }
}
