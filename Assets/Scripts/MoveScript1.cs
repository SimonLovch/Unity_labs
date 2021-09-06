using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveScript1 : MonoBehaviour
{
    public Text val;
    public bool start = false;
    public Material HitMat;
    public Material defMat;
    public Material blueMat;

    private Renderer ren;

    [Range(0.1f, 100f)]
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        val.text = speed.ToString();
        ren = GetComponent<Renderer>();
        ren.material = defMat;


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
            transform.position += transform.right * Time.deltaTime * speed;
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

    
}
