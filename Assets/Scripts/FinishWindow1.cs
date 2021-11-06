using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWindow1 : MonoBehaviour
{
    public GameObject modalWindow;
    // Start is called before the first frame update
    void Start()
    {
        modalWindow.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            modalWindow.SetActive(true);

        }
    }
}
