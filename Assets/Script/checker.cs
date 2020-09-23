using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class checker : MonoBehaviour
{

    public static bool scoreStop;
    public GameObject gameOverText;
    public Text gameOverScoreText;
    public float speed = 0.04f;
    public GameObject gameOverScoreTexObject;

    public GameObject destroyChecker;


    ScoreController scoreController;
    public GameObject ScoreControllerObject;


    // Start is called before the first frame update
    void Start()
    {
        scoreController = ScoreControllerObject.GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("wallChecker"))
        {
            Debug.Log("当たった");
            scoreStop = true;
            gameOverText.SetActive(true);
            gameOverScoreTexObject.SetActive(true);
            gameOverScoreText.text = "High Score : " + scoreController.scoreCount.ToString("f0");


        }


       



    }
}
