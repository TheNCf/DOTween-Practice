using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotateScaleAnimation : MonoBehaviour
{
    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(4.0f, 1.0f));
        sequence.Join(transform.DORotate(new Vector3(180.0f, 0.0f, 0.0f), 1.0f));
        sequence.Join(transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 1.0f));

        sequence.SetEase(Ease.InOutQuad);
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
