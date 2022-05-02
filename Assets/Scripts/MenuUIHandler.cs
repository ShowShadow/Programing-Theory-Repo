using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField nameInputField;
    public static string playerName;
    public GameObject startButton;

    public void activateStartButton()
    {
        startButton.gameObject.SetActive(true);
    }

    public void startGame()
    {
        playerName = nameInputField.GetComponent<InputField>().text;
        SceneManager.LoadScene("Scene");
    }
}
