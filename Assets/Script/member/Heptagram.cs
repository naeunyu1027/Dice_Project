using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Heptagram : MonoBehaviour
{
    public GameObject StatScript;
    public GameObject StatText;
    
    private void Start()
    {
        StatScript = this.gameObject;
        stat Staters = StatScript.GetComponent<stat>();
        
        if (gameObject.CompareTag("PlayerCard"))
        {
            StatText = GameObject.FindWithTag("PlayerCardText");
        }

        if (gameObject.CompareTag("AiCard"))
        {
            StatText = GameObject.FindWithTag("AiCardText");
        }
        
        
        
        
        int condition = Random.Range(1, 3);

        switch (condition)
        {
            case 1:
                StatText.GetComponent<TextMeshPro>().text = "야근";
                StatText.SetActive(true);
                Staters.ZeroCondition();
                // Debug.Log($"각별 쓰러짐");
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "제작자 최애임";
                StatText.SetActive(true);
                Staters.Power = 110;
                Staters.SixthSense = 110;
                Staters.HandIness = 110;
                Staters.Information = 110;
                Staters.Insight = 110;
                Staters.Persuasion = 110;
                // Debug.Log("제작자 최애 특권");
                break;
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "돈 받음";
                StatText.SetActive(true);
                Staters.Information = 80;
                Staters.Insight = 70;
                Staters.Persuasion = 40;
                // Debug.Log("돈 받은 각별");
                break;
            case 4:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 3;
                Staters.SixthSense = 50;
                Staters.HandIness = 100;
                Staters.Information = 65;
                Staters.Insight = 60;
                Staters.Persuasion = 10;
                // Debug.Log("각별 평소 상태");
                break;
        }
    }
}
