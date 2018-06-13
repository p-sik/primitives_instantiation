using Assets.PrimitivesInstantiation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimitiveCreator : MonoBehaviour
{
    [SerializeField] Vector3 objectScale = Vector3.one;
    [SerializeField] ShapeType primitiveShape;

    public void InstantiatePrimitiveElement()
    {
        PrimitiveType shape = ConvertEnum(primitiveShape);
        PrimitiveInstantiator.CreatePrimitive(shape, objectScale);
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
