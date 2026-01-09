using System;
using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] public int NbLife = 3;
    [SerializeField] TextMeshProUGUI LifeText;
    [SerializeField] private Animation Life1;
    [SerializeField] private Animation Life2;
    [SerializeField] private Animation Life3;
    [SerializeField] private Animation Alarm;

    public void LoseLife()
    {
        //LifeText.text = NbLife.ToString();
        if (NbLife == 3)
        {
            Life1.Play("LifeAnimation");
        }
        else if (NbLife == 2)
        {
            Life2.Play("LifeAnimation");
        }
        else if (NbLife == 1)
        {
            Life3.Play("LifeAnimation");
        }
        NbLife-=1;
    }

    private void Update()
    {
        if (NbLife == 1)
        {
            Alarm.Play("Alarm");
        }
    }
}
