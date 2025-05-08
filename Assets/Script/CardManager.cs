using TMPro;
using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;
    
    public GameObject[] cards;
    
    //카드
    public bool CardExecuted = false;
    public Transform cardParent;
    public bool CardExecuted2 = false;
    public Transform cardParent2;
    
    //카드 생성될 때 나올 텍스트
    public TextMeshProUGUI[] cardText;
    public Transform cardTextParent;
    private int random;
    
    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
    }

    public void Cardspawn()
    {
        CardExecuted = false;
        foreach (Transform child in cardParent)
        {
            Destroy(child.gameObject);
        }
        if (!CardExecuted && GameManager.Instance.diceNumber > 0)
        {
            GameObject PlayerCard = Instantiate(cards[GameManager.Instance.diceNumber-1], cardParent);
            PlayerCard.tag = "PlayerCard";
            StartCoroutine(StartText());
            CardFight.Instance.PlayerCard = PlayerCard;
            CardExecuted = true;
        }
    }
    
    public void Cardspawn2()
    {
        CardExecuted2 = false;
        foreach (Transform child in cardParent2)
        {
            Destroy(child.gameObject);
        }
        random = Random.Range(1, 6);
        if (!CardExecuted2)
        {
            GameObject AiCard = Instantiate(cards[random-1], cardParent2);
            AiCard.tag = "AiCard";
            CardFight.Instance.AiCard = AiCard;
            CardExecuted2 = true;
            CardFight.Instance.startpvp();
        }
    }

    IEnumerator StartText() //뽑힌 멤버 텍스트
    {
        Instantiate(cardText[GameManager.Instance.diceNumber-1], cardTextParent);
        
        yield return new WaitForSeconds(2f);
        foreach (Transform child in cardTextParent)
        {
            Destroy(child.gameObject);
        }
    }
    

}
