using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : TweenAnimation
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Duration)
            .SetLoops(LoopCount, LoopType)
            .SetEase(EaseType);
    }
}
