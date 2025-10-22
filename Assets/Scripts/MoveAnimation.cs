using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : TweenAnimation
{
    [SerializeField] private Vector3 _translation;

    private void Start()
    {
        transform.DOMove(_translation, Duration)
            .SetRelative()
            .SetLoops(LoopCount, LoopType)
            .SetEase(EaseType);
    }
}
