using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneInstantiator : MonoBehaviour
{
    [SerializeField] Vector3 desiredPosition;
    [SerializeField] Vector3 desiredScale;

    //TODO what minimum scale makes sense?
    public void InstantiatePlaneElement()
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Plane"), desiredPosition, Quaternion.identity);
        desiredScale = Vector3.Max(desiredScale, Vector3.one * 10);
        go.transform.localScale = desiredScale;
    }

}
