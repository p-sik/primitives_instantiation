using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.PrimitivesInstantiation
{
    public static class PrimitiveInstantiator
    {
        public static GameObject CreatePrimitive(PrimitiveType shape, Vector3 scale)
        {
            scale = Vector3.Max(scale, Vector3.one);
            GameObject instance = GameObject.CreatePrimitive(shape);
            instance.transform.localScale = scale;
            return instance;
        }
    }
}
