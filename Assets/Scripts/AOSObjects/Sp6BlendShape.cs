using AosSdk.Core.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp6BlendShape : AosObjectBase
{
    public int BlendShape = 0;
    public float  BlendShape2 = 100f;
    private SkinnedMeshRenderer skinnedMesh;
    private void Start()
    {
         skinnedMesh = GetComponent<SkinnedMeshRenderer>();
        
    }
    public void SetCondition(bool value)
    {
        Debug.Log("IN");
        if(value)
        skinnedMesh.SetBlendShapeWeight(BlendShape, BlendShape2);
        else
            skinnedMesh.SetBlendShapeWeight(BlendShape, BlendShape);
    }
}

