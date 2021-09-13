using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;
    [SerializeField] Button addPointButton;
    int points;

    void Awake()
    {
        addPointButton.onClick.AddListener(() =>
        {
            AddPoint();
            UpdatePointsText();
        });
    }

    void Update()
    {
        CheckBonusPoint();
    }

    void Start()
    {
        points = 0;
        pointsText.text = points.ToString();
    }

    void AddPoint()
    {
        points++;
    }

    void UpdatePointsText()
    {
        pointsText.text = points.ToString();
    }

    void CheckBonusPoint()
    {
        if (points % 2 == 0 && Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.V))
        {
            points += 10001;
            UpdatePointsText();
        }
    }
}
