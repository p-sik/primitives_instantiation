using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING_clicks : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Ray rScreen = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit rh;
            if (Physics.Raycast(rScreen, out rh))
            {
                print(rh.collider.gameObject.name);
            }
        }
    }
}
