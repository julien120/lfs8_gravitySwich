using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool scoreStop;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0.1f, 0, 0);

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 100f,0));
        }

    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.CompareTag("wallChecker"))
        {
            Debug.Log("当たった");
            scoreStop = true;
        }
    }

}
