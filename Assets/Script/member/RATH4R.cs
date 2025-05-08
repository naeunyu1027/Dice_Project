using TMPro;
using UnityEngine;

public class RATH4R : MonoBehaviour
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
        

        int condition = Random.Range(1, 4);

        switch (condition)
        {
            case 1:
                StatText.GetComponent<TextMeshPro>().text = "삐졌음";
                StatText.SetActive(true);
                Staters.ZeroCondition();
                break;
            case 2:
                StatText.GetComponent<TextMeshPro>().text = "혼나서 쭈글이됨";
                StatText.SetActive(true);
                Staters.Power = 10;
                break;
            case 3:
                StatText.GetComponent<TextMeshPro>().text = "평소 상태";
                StatText.SetActive(true);
                Staters.Power = 100;
                Staters.SixthSense = 25;
                Staters.HandIness = 10;
                Staters.Information = 40;
                Staters.Insight = 30;
                Staters.Persuasion = 10;
                // Debug.Log("라더 평소 상태");
                break;
        }
    }
}
