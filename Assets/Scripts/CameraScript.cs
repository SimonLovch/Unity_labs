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
            MoveScript1 mv;
            
            if (objectHit.TryGetComponent<MoveScript1>(out mv) == true)
            {
                mv.select();

                if (Input.GetAxis("Fire1") > 0)
                {
                    mv.start = true;
                }
            }
        }
    }
}
