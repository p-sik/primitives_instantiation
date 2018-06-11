using Assets.PrimitivesInstantiation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimitiveCreator : MonoBehaviour
{
    [SerializeField] Vector3 objectScale = Vector3.one;
    [SerializeField] ShapeType primitiveShape;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(100, 100, 600, 240), "Instantiate"))
        {
            PrimitiveType shape = ConvertEnum(primitiveShape);
            PrimitiveInstantiator.Instantiate(shape, objectScale);
        }
    }

    private PrimitiveType ConvertEnum(ShapeType inputShape)
    {
        switch (inputShape)
        {
            default:
            case ShapeType.Cube:
                return PrimitiveType.Cube;
            case ShapeType.Sphere:
                return PrimitiveType.Sphere;
            case ShapeType.Cylinder:
                return PrimitiveType.Cylinder;
            case ShapeType.Capsule:
                return PrimitiveType.Capsule;
        }
    }

    enum ShapeType
    {
        Cube,
        Sphere,
        Cylinder,
        Capsule
    }
}
