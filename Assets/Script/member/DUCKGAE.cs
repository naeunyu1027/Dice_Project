using TMPro;
using UnityEngine;

public class DUCKGAE : MonoBehaviour
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
        
        
        /*Staters.Power;
        Staters.SixthSense;
        Staters.HandIness;
        Staters.Information;
        Staters.Insight;
        Staters.Persuasion;*/
        
        int condition = Random.Range(1, 4);

        switch (condition)
        {
            case 1:
                StatText.GetComponent<TextMeshPro>().text = "덕개 진짜 개됨";
                StatText.SetActive(true);
                Staters.HandIness = 0;
                Staters.Information = 4;
                Staters.Insight = 1;
                Staters.Persuasion = 100;
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "많이 억울함";
                StatText.SetActive(true);
                Staters.Power = 90;
                Staters.Persuasion = 10;
                // Debug.Log("덕개 놀림당함");
                break;
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 60;
                Staters.SixthSense = 100;
                Staters.HandIness = 10;
                Staters.Information = 35;
                Staters.Insight = 30;
                Staters.Persuasion = 65;
                // Debug.Log("덕개 평소 상태");
                break;
        }
    }
}
