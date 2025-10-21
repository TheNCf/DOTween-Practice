using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialAnimation : MonoBehaviour
{
    private Material _material;

    void Start()
    {
        _material = GetComponent<MeshRenderer>().material;

        _material.DOColor(Color.red, 1.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
    }
}
