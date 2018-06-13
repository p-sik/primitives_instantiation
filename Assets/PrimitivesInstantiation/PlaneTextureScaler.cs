using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTextureScaler : MonoBehaviour
{
    private const int BASE_SCALE = 50;
    Material mat;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        Vector3 scale = gameObject.transform.localScale;
        Vector2 scale2D = new Vector2(scale.x / BASE_SCALE, scale.z / BASE_SCALE);
        mat.SetTextureScale("_MainTex", scale2D);
    }
}
