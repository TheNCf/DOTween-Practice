using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TweenAnimation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Ease _easeType;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;
    [SerializeField] private int _loopCount = -1;

    public float Duration => _duration;
    public Ease EaseType => _easeType;
    public LoopType LoopType => _loopType;
    public int LoopCount => _loopCount;
}
