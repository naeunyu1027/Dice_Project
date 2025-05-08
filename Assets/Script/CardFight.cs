using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CardFight : MonoBehaviour
{
    public static CardFight Instance; //CardManager에서 사용
    
    public GameObject AiCard;
    public GameObject PlayerCard;

    private stat Aicardstat;
    private stat Playerstat;
    
    [SerializeField] private GameObject EventText;
    [SerializeField] private TextMeshProUGUI EventTextC;
    [SerializeField] private TextMeshProUGUI Result;
    [SerializeField] private GameObject ResultTF;

    private void Awake()    
    {
        // 싱글톤 인스턴스 설정
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    public void startpvp()
    {
        Aicardstat = AiCard.GetComponent<stat>();
        Playerstat = PlayerCard.GetComponent<stat>();
    }

    public IEnumerator FEvent()
    {
        switch (GameManager.Instance.diceNumber)
        {
            case 1:
                
                Debug.Log("종목 1");
                StartCoroutine(PowereEvent());
                break;
            case 2:
                Debug.Log("종목 2");
                StartCoroutine(SixthSenseEvent());
                break;
            case 3:
                Debug.Log("종목 3");
                StartCoroutine(HandInessEvent());
                break;
            case 4:
                Debug.Log("종목 4");
                StartCoroutine(InformationEvent());
                break;
            case 5:
                Debug.Log("종목 5");
                StartCoroutine(InsightEvent());
                break;
            case 6:
                Debug.Log("종목 6");
                StartCoroutine(PersuasionEvent());
                break;
        }

        yield return new WaitForSeconds(1f);

    }

    IEnumerator PowereEvent()
    {
        EventTextC.text = "힘";
        EventText.SetActive(true);
        yield return new WaitForSeconds(2f);
        EventText.SetActive(false);
        if (Playerstat.Power > Aicardstat.Power)
        {
            Result.text = "플레이어 승리!";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("플레이어 승리");
            
        }
        else if (Playerstat.Power == Aicardstat.Power)
        {
            Result.text = "무승부";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("무승부");
        }
        else if (Playerstat.Power < Aicardstat.Power)
        {
            Result.text = "플레이어 패배!";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("플레이어 패배");
        }
    }
//////////////////////////////////////////////////////////////////////////////////
    IEnumerator SixthSenseEvent()
    {
        EventTextC.text = "직감";
        EventText.SetActive(true);
        yield return new WaitForSeconds(2f);
        EventText.SetActive(false);
        if (Playerstat.SixthSense > Aicardstat.SixthSense) {
            Result.text = "플레이어 승리!";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("플레이어 승리");
            
        }
        else if (Playerstat.SixthSense == Aicardstat.SixthSense){
            Result.text = "무승부";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("무승부");
        }
        else if (Playerstat.SixthSense < Aicardstat.SixthSense)
        {
            Result.text = "플레이어 패배!";
            ResultTF.SetActive(true);
            yield return new WaitForSeconds(2f);
            ResultTF.SetActive(false);
            Debug.Log("플레이어 패배");
        }
    }
//////////////////////////////////////////////////////////////////////////////////
    IEnumerator HandInessEvent()
        {
            EventTextC.text = "손재주";
            EventText.SetActive(true);
            yield return new WaitForSeconds(2f);
            EventText.SetActive(false);
            if (Playerstat.HandIness > Aicardstat.HandIness)
            {
                Result.text = "플레이어 승리!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 승리");
            
            }
            else if (Playerstat.HandIness == Aicardstat.HandIness){
                Result.text = "무승부";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("무승부");
            }
            else if (Playerstat.HandIness < Aicardstat.HandIness)
            {
                Result.text = "플레이어 패배!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 패배");
            }
        }
//////////////////////////////////////////////////////////////////////////////////
    IEnumerator InformationEvent()
        {
            EventText.SetActive(true);
            EventTextC.text = "정보";
            yield return new WaitForSeconds(2f);
            EventText.SetActive(false);
            if (Playerstat.Information > Aicardstat.Information){
                Result.text = "플레이어 승리!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 승리");
            
            }
            else if (Playerstat.Information == Aicardstat.Information){
                Result.text = "무승부";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("무승부");
            }
            else if (Playerstat.Information < Aicardstat.Information){
                Result.text = "플레이어 패배!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 패배");
            }
        }
//////////////////////////////////////////////////////////////////////////////////
    IEnumerator InsightEvent()
        {
            EventText.SetActive(true);
            EventTextC.text = "추리";
            yield return new WaitForSeconds(2f);
            EventText.SetActive(false);
            if (Playerstat.Insight > Aicardstat.Insight){
                Result.text = "플레이어 승리!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 승리");
            
            }
            else if (Playerstat.Insight == Aicardstat.Insight){
                Result.text = "무승부";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("무승부");
            }
            else if (Playerstat.Insight < Aicardstat.Insight){
                Result.text = "플레이어 패배!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 패배");
            }
        }
//////////////////////////////////////////////////////////////////////////////////
    IEnumerator PersuasionEvent()
        {
            EventText.SetActive(true);
            EventTextC.text = "언변";
            yield return new WaitForSeconds(2f);
            EventText.SetActive(false);
            if (Playerstat.Persuasion > Aicardstat.Persuasion){
                Result.text = "플레이어 승리!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 승리");
            
            }
            else if (Playerstat.Persuasion == Aicardstat.Persuasion){
                Result.text = "무승부";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("무승부");
            }
            else if (Playerstat.Persuasion < Aicardstat.Persuasion){
                Result.text = "플레이어 패배!";
                ResultTF.SetActive(true);
                yield return new WaitForSeconds(2f);
                ResultTF.SetActive(false);
                Debug.Log("플레이어 패배");
            }
        }

    
}
