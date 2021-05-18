using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
       string clickObj = EventSystem.current.currentSelectedGameObject.name;
     //   SceneManager.LoadScene("Gameplay");
    }
}
