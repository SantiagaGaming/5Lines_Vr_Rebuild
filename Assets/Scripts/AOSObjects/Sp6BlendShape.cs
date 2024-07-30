using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sp6BlendShape : MonoBehaviour
{
    public int BlendShape = 0;
    public float  BlendShape2 = 100f;
    private SkinnedMeshRenderer skinnedMesh;
    private void Start()
    {
         skinnedMesh = GetComponent<SkinnedMeshRenderer>();
        if (skinnedMesh != null)
        {
            StartCoroutine(SetBlendShape());
        }
    }
    private IEnumerator SetBlendShape()
    {
        yield return new WaitForSeconds(5);
        skinnedMesh.SetBlendShapeWeight(BlendShape, BlendShape2);
    }
}

