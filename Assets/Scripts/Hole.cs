using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Hole : MonoBehaviour
{
    public float StarvationRate;
    public float FoodScore;
    public float MaxFoodScore;
    public TextMeshProUGUI MaxScoreText;
    public GameObject AddedScoreTextPrefab;
    public Slider HealthBar;

    [SerializeField] private GameManage gameManager;

    private void Start()
    {
        MaxFoodScore = FoodScore;
        MaxScoreText.text = Math.Floor(FoodScore).ToString();
        MaxScoreText.text = Math.Floor(MaxFoodScore).ToString();
        HealthBar.maxValue = MaxFoodScore;
        HealthBar.value = FoodScore;
    }

    public void Eat(float changeFoodScore)
    {
        if (GameManage.IsPaused) return;
        
        FoodScore += changeFoodScore;

        if (FoodScore < 0)
        {
            FoodScore = 0;
        }

        if (FoodScore > MaxFoodScore)
        {
            MaxFoodScore = FoodScore;
            HealthBar.maxValue = MaxFoodScore;
            MaxScoreText.text = Math.Floor(MaxFoodScore).ToString();
        }

        HealthBar.value = FoodScore;
        transform.localScale += new Vector3(changeFoodScore / 10, changeFoodScore / 10, changeFoodScore / 10);
        
    }

    private void FixedUpdate()
    {
        if (GameManage.IsPaused) return;        
        if (FoodScore > 0)
        {
            var StarveValue = FoodScore * StarvationRate;
            Eat(-StarveValue);
        }
    }
}
