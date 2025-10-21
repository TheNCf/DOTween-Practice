using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveY(4.0f, 1.0f).SetRelative().SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
    }
}
