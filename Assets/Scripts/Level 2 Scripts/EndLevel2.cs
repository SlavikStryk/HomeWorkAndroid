using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel2 : MonoBehaviour
{
    public Rigidbody2D rb2;
    public Button rbutton2;
    public Button nbutton2;
    public Button mbutton2;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rbutton2.onClick.AddListener(() => Restart2());
        nbutton2.onClick.AddListener(() => Next2());
        mbutton2.onClick.AddListener(() => Menu2());
    }

    void Restart2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Next2()
    {
        // Load code Level 3
    }

    void Menu2()
    {
        // Load code main menu
    }
}
