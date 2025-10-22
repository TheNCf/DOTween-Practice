using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : TweenAnimation
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(EaseType);
    }
}
