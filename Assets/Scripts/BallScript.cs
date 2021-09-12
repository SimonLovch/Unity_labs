using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    private Vector3 oldPos;
    public Text val;
    public bool start = false;
    public GameObject endPoint;
    private Renderer ren;

    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
         oldPos = transform.position; 
         val.text = speed.ToString();
         ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
