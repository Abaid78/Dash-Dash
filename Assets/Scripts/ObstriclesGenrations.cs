using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstriclesGenrations : MonoBehaviour
{
    public GameObject prefabl;
    public Transform geratepoint;
    public string genratePoint;
    // Start is called before the first frame update
    void Start()
    {
        //geratepoint = GameObject.FindWithTag(genratePoint).transform;
    }
    void Gen()
    {
        Instantiate(prefabl, geratepoint.position, Quaternion.identity);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float range = Random.Range(0.1f,0.8f);
        Invoke("Gen", range);
       
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }
            
    }
}
