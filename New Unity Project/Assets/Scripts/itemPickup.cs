using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class itemPickup : MonoBehaviour
{
    public GameObject scoreText;
    public static int scoreCount;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && scoreCount == 3)
        {
            print("Level Complete!");
            SceneManager.LoadScene("Level 2");
        }

        if (collider.gameObject.tag == "Player")
        {
            print("Key picked up");

            scoreCount++;
            Destroy(gameObject);
            Update();
        }
        void Update()
        {
            print(+scoreCount);
            scoreText.GetComponent<Text>().text = "KEYS: " + scoreCount;
        }
    }
}
