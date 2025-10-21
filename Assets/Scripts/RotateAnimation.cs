using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DORotate(new Vector3(0.0f, 180.0f, 0.0f), 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
    }
}
