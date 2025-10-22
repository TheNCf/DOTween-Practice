using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class MaterialAnimation : TweenAnimation
{
    [SerializeField] private Color _color;

    private Material _material;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;

        _material.DOColor(_color, Duration)
            .SetLoops(LoopCount, LoopType)
            .SetEase(EaseType);
    }
}
