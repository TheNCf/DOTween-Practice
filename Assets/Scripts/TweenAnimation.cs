using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TweenAnimation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Ease _easeType;

    public float Duration => _duration;
    public Ease EaseType => _easeType;
}
