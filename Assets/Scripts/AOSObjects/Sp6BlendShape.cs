using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp6BlendShape : AosObjectBase
{
    public int BlendShape = 0;
    public float BlendShape2 = 100f;
    private SkinnedMeshRenderer skinnedMesh;
    [SerializeField] private SkinnedMeshRenderer _reg1Mesh;
    [SerializeField] private SkinnedMeshRenderer _reg2Mesh;
    private void Start()
    {
        skinnedMesh = GetComponent<SkinnedMeshRenderer>();

    }
    public void SetCondition(bool value)
    {

        if (value)
        {
            skinnedMesh.SetBlendShapeWeight(BlendShape, BlendShape2);
            if (_reg1Mesh != null && _reg2Mesh != null)
            {
                _reg1Mesh.SetBlendShapeWeight(BlendShape, BlendShape2);
                _reg2Mesh.SetBlendShapeWeight(BlendShape, BlendShape2);
            }

        }

        else
        {
            skinnedMesh.SetBlendShapeWeight(BlendShape, BlendShape);
            if (_reg1Mesh != null && _reg2Mesh != null)
            {
                _reg1Mesh.SetBlendShapeWeight(BlendShape, BlendShape);
                _reg2Mesh.SetBlendShapeWeight(BlendShape, BlendShape);
            }
        }

    }
}

