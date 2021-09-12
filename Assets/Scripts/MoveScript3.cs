using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript3 : MonoBehaviour
{
    private Vector3 oldPos;
    public Text val;
    public bool start = false;
    public Material HitMat;
    public Material defMat;
    public Material blueMat;
    private Rigidbody rb;
    private Renderer ren;

    [Range(0.1f, 100f)]
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = transform.position;
        val.text = speed.ToString();
        ren = GetComponent<Renderer>();
        ren.material = defMat;
        rb = GetComponent<Rigidbody>();
    }
    public void setSpeed(float value)
    {
        Debug.Log(value.ToString());
        speed = value;
        val.text = speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    public void select()
    {
        ren.material = blueMat;
    }
    private void OnCollisionEnter(Collision collision)
    {
        ren.material = HitMat;
    }

    public void reset()
    {
        transform.position = oldPos;
        start = false;
        ren.material = defMat;
    }
}
