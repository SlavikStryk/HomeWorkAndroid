using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector2 : MonoBehaviour
{
    private int cherries = 0;
    public GameObject modalWindow;
    public Rigidbody2D rb;
    [SerializeField] private Text cherriesText;
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Items"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "x" + cherries;
        }

        else if (collision.gameObject.CompareTag("FinishBox"))
        {
            modalWindow.SetActive(true);
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
