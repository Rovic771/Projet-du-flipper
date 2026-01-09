using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.SceneManagement.Scene;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animation ButtonPlayAnimation;
    
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject MainMenu2;

    public void PlayAnimation()
    {
        MainMenu.SetActive(false);
        StartCoroutine(SequenceChangementMenu());
    }
    
    IEnumerator SequenceChangementMenu()
    {
        ButtonPlayAnimation.Play();
        
        yield return new WaitForSeconds(ButtonPlayAnimation.clip.length);
        
        MainMenu2.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
