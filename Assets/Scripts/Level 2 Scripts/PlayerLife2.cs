using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife2 : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] private Text player_hp;
    void Start()
    {
        if (PlayerPrefs.GetInt("HP") == null)
        {
            PlayerPrefs.SetInt("HP", 3);
        }
        player_hp.text = "x" + PlayerPrefs.GetInt("HP");
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        animator.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;
        PlayerPrefs.SetInt("HP", PlayerPrefs.GetInt("HP") - 1);
        player_hp.text = "x" + PlayerPrefs.GetInt("HP");
    }

    public void RestartLevel()
    {
        if (PlayerPrefs.GetInt("HP") > 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        else
        {
            SceneManager.LoadScene("Death");
        }
        player_hp.text = "x" + PlayerPrefs.GetInt("HP");
    }
}
