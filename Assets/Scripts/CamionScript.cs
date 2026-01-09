using System;
using TMPro;
using UnityEngine;

public class CamionScript : MonoBehaviour
{
    [SerializeField] private Animation AnimationCamion;
    [SerializeField] private Animation AnimationRoue;
    public int NbCaisse = 0;
    public int NbCaisseExport = 0;

    private void Update()
    {
        if (NbCaisse == 5)
        {
            NbCaisse = 0;
            AnimationCamion.Play("Camion");
            AnimationRoue.Play("RoueCamion");
            NbCaisseExport += 5;
        }
    }
}
