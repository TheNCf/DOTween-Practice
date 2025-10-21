using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshRenderer))]
public class TextAnimation : MonoBehaviour
{
    private Text _text;

    void Start()
    {
        _text = GetComponent<Text>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Text replaced", 1.0f));
        sequence.AppendInterval(1.0f);
        sequence.Append(_text.DOText(".\n Text added", 1.0f).SetRelative(true));
        sequence.AppendInterval(1.0f);
        sequence.Append(_text.DOText("Text scrambled", 1.0f, scrambleMode: ScrambleMode.All));
        sequence.AppendInterval(1.0f);

        sequence.SetLoops(-1, LoopType.Restart);
    }
}
