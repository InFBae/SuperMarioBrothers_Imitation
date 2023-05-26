using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinView : MonoBehaviour
{
    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        GameManager.Data.OnCurCoinChanged += ChangeScore;

    }

    private void ChangeScore(int score)
    {
        text.text = score.ToString();
    }
}
