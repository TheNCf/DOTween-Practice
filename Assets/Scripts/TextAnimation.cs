using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshRenderer))]
public class TextAnimation : TweenAnimation
{
    [SerializeField] private string _replacedText = "Text replaced";
    [SerializeField] private string _addedText = ".\n Text added";
    [SerializeField] private string _scrambledText = "Text scrambled";

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Text replaced", Duration));
        sequence.AppendInterval(Duration);
        sequence.Append(_text.DOText(".\n Text added", Duration).SetRelative(true));
        sequence.AppendInterval(Duration);
        sequence.Append(_text.DOText("Text scrambled", Duration, scrambleMode: ScrambleMode.All));
        sequence.AppendInterval(Duration);

        sequence.SetLoops(-1, LoopType.Restart);
        sequence.SetEase(EaseType);
    }
}
