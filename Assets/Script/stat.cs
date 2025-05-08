using System.Collections.Generic;
using UnityEngine;


public class stat : MonoBehaviour
{
    public int Power;
    public int SixthSense;
    public int HandIness ;
    public int Information;
    public int Insight;
    public int Persuasion;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ZeroCondition()
    {
        Power = 0;
        SixthSense = 0;
        HandIness = 0;
        Information = 5;
        Insight = 0;
        Persuasion = 0;
    }
}
