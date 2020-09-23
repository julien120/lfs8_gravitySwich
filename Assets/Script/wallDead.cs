using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDead : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

        //playerController = player.GetComponent<PlayerController>();

        StartCoroutine("wallDeads");

      
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        //Debug.Log("見えない！");
       // Destroy(gameObject, 10);
    }

    IEnumerator wallDeads()
    { 
        yield return new WaitForSeconds(10);
        if (PlayerController.scoreStop == false)
        {
       Debug.Log("こルーチン");
       Destroy(gameObject);
        }
    }



}
