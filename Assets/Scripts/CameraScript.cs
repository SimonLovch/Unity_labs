using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    private void LateUpdate()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            MoveScript1 mv;  // SetPosition
            MoveScript2 mv2; // MovePosition
            MoveScript3 mv3; // AddForce
            MoveScript4 mv4; // Translate
            MoveScript5 mv5; // SetVelocity
            if (objectHit.TryGetComponent<MoveScript1>(out mv) == true)
            {
                mv.select();

                if (Input.GetAxis("Fire1") > 0)
                {
                    mv.start = true;
                }
            }

            if (objectHit.TryGetComponent<MoveScript2>(out mv2) == true)
            {
                mv2.select();

                if (Input.GetAxis("Fire1") > 0)
                {
                    mv2.start = true;
                }
            }

            if (objectHit.TryGetComponent<MoveScript3>(out mv3) == true)
            {
                mv3.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    mv3.start = true;
                }
            }

            if (objectHit.TryGetComponent<MoveScript4>(out mv4) == true)
            {
                mv4.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    mv4.start = true;
                }
            }

            if (objectHit.TryGetComponent<MoveScript5>(out mv5) == true)
            {
                mv5.select();
                if (Input.GetAxis("Fire1") > 0)
                {
                    mv5.start = true;
                }
            }
        }
    }
}
