using System.Collections;
using TMPro;
using UnityEngine;

public class EventSelect : MonoBehaviour
{
    public static EventSelect instance;
    
    [SerializeField] private GameObject CardFight;
    [SerializeField] private GameObject DiceController;
    /*[SerializeField] */
    public GameObject EventText;
    

    private void Awake()
    {
        if(instance == null) instance = this;
    }

    void Update()
    {
        if(DiceController.GetComponent<DiceController>().FEC)
        {
            EventText.SetActive(true);
        }
    }
    
    public IEnumerator FightEvent()
    {
        DiceController.GetComponent<DiceController>().FEC = false;
        EventText.SetActive(false);
        while (DiceController.GetComponent<DiceController>().rb.velocity.magnitude > 0.2f 
               || DiceController.GetComponent<DiceController>().rb.angularVelocity.magnitude > 0.2f)
        {
            yield return null;
        }
        yield return new WaitForSeconds(5f);
        StartCoroutine(CardFight.GetComponent<CardFight>().FEvent());
        
        yield return new WaitForSeconds(6f);
        DiceController.GetComponent<DiceController>().diceCheck = false;
    }
}
