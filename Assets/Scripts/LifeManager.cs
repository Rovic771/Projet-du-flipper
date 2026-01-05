using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] public int NbLife = 3;
    [SerializeField] TextMeshProUGUI LifeText;

    public void LoseLife()
    {
        NbLife-=1;
        LifeText.text = NbLife.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
