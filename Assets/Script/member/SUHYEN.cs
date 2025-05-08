using System.Collections;
using TMPro;
using UnityEngine;

public class SUHYEN : MonoBehaviour
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
        int condition = Random.Range(1, 5);

        switch (condition)
        {
            case 1:
                StatText.GetComponent<TextMeshPro>().text = "억울함";
                StatText.SetActive(true);
                Staters.Power = 60;
                Staters.SixthSense = 10;
                Staters.HandIness = 10;
                Staters.Information = 30;
                Staters.Insight = 25;
                Staters.Persuasion = 50;
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "가끔은 무력도 좋은 대화 수단";
                StatText.SetActive(true);
                Staters.Power = 90;
                Staters.HandIness = 10;
                Staters.Persuasion = 100;
                break;
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 50;
                Staters.SixthSense = 20;
                Staters.HandIness = 30;
                Staters.Information = 40;
                Staters.Insight = 35;
                Staters.Persuasion = 100;
                // Debug.Log("수현 평소 상태");
                break;
        }
    }
}
