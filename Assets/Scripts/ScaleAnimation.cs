using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DOScale(new Vector3(2.0f, 2.0f, 2.0f), 1.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
    }
}
