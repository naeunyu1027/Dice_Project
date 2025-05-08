using TMPro;
using UnityEngine;

public class ehdgh141 : MonoBehaviour
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
                StatText.GetComponent<TextMeshPro>().text = "술마심";
                StatText.SetActive(true);
                Staters.ZeroCondition();
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "공룡 진짜 공룡됨";
                StatText.SetActive(true);
                Staters.ZeroCondition();
                Staters.Power = 1000;
                break;
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 40;
                Staters.SixthSense = 50;
                Staters.HandIness = 5;
                Staters.Information = 100;
                Staters.Insight = 70;
                Staters.Persuasion = 25;
                break;
        }
    }

}
