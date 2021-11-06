using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndLevel1 : MonoBehaviour
{
    private int id = 0;
    public Rigidbody2D rb;
    public Button rbutton;
    public Button nbutton;
    public Button mbutton;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rbutton.onClick.AddListener(() => Restart());
        nbutton.onClick.AddListener(() => Next());
        mbutton.onClick.AddListener(() => Menu());
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Next()
    {
        id++;
        Debug.Log("ID Click: "+id);
        SceneManager.LoadScene("Level2");
    }

    void Menu()
    {
        // Load code main menu
    }
}
