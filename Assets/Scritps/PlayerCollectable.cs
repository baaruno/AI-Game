using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollectable : MonoBehaviour
{
    float spinSpeed = 0.5f;
    public int coins = 0;
    public Text coinText;
    private System.Random rand = new System.Random();
    public AudioSource collectSound;
    
    public GameObject canvas;

    //GameOver Panel
    public GameObject none;
    public Text totalCoinsNone;
    public GameObject bronze;
    public Text totalCoinsBronze;
    public GameObject silver;
    public Text totalCoinsSilver;
    public GameObject gold;
    public Text totalCoinsGold;
    public GameObject diamond;
    public Text totalCoinsDiamond;
    
    public bool isGameOver;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed);

        coinText.text = ""+coins;

        //GameOver
        if(isGameOver)
        {
            
        }
    }

    IEnumerator Respawn (Collider collision, int time)
    {
        yield return new WaitForSeconds(time);
        collision.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Coin"))
        {   
            Debug.Log("Koin diambil");
            collision.gameObject.SetActive(false);
            collectSound.Play();
            StartCoroutine(Respawn(collision, rand.Next(10, 15)));
        }
        
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("Ketabrak");
            
            if (coins < 5)
            {
                canvas.SetActive(false);
                none.SetActive(true);
                totalCoinsNone.text = ""+coins;

                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }  

            else if (coins < 10)
            {
                canvas.SetActive(false);
                bronze.SetActive(true);
                totalCoinsBronze.text = ""+coins;

                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            else if (coins < 20)
            {
                canvas.SetActive(false);
                silver.SetActive(true);
                totalCoinsSilver.text = ""+coins;

                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            else if (coins < 30)
            {
                canvas.SetActive(false);
                gold.SetActive(true);
                totalCoinsGold.text = ""+coins;

                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            else if (coins >= 30)
            {
                canvas.SetActive(false);
                diamond.SetActive(true);
                totalCoinsDiamond.text = ""+coins;

                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

}
