using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private Button selectButton;
    [SerializeField] private Button exitButton;
    void Start()
    {
        selectButton.onClick.AddListener(() => SelectLevel());
        exitButton.onClick.AddListener(() => Exit());
    }

    private void SelectLevel()
    {

    }

    private void Exit()
    {
        Application.Quit();
    }
}
