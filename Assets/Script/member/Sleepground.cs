using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Sleepground : MonoBehaviour
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
                StatText.GetComponent<TextMeshPro>().text = "그저 잠뜰";
                StatText.SetActive(true);
                Staters.Power = 110;
                Staters.SixthSense = 110;
                Staters.HandIness = 110;
                Staters.Information = 110;
                Staters.Insight = 110;
                Staters.Persuasion = 110;
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "빡침";
                StatText.SetActive(true);
                Staters.Power = 111;
                Staters.SixthSense = 111;
                Staters.HandIness = 111;
                Staters.Information = 111;
                Staters.Insight = 111;
                Staters.Persuasion = 111;
                break;  
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 10;
                Staters.SixthSense = 60;
                Staters.HandIness = 30;
                Staters.Information = 65;
                Staters.Insight = 100;
                Staters.Persuasion = 50;
                // Debug.Log("잠뜰 평소 상태");
                break;
        }
    }
}
