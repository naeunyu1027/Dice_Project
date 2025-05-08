using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    private Vector3 diceVelocity;
    private DiceController _diceController;
    
    void Start()
    {
        _diceController = FindObjectOfType<DiceController>();
    }

    void FixedUpdate()
    {
        diceVelocity = _diceController.diceVelocity;
    }

    void OnTriggerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    GameManager.Instance.diceNumber = 6;
                    break;
                case "Side2":
                    GameManager.Instance.diceNumber = 5;
                    break;
                case "Side3":
                    GameManager.Instance.diceNumber = 4;
                    break;
                case "Side4":
                    GameManager.Instance.diceNumber = 3;
                    break;
                case "Side5":
                    GameManager.Instance.diceNumber = 2;
                    break;
                case "Side6":
                    GameManager.Instance.diceNumber = 1;
                    break;
            }

        }
    }
}
