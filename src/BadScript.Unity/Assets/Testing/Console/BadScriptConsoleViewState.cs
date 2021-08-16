using System;
using UnityEngine;

[Serializable]
public class BadScriptConsoleViewState
{
    public bool Show;
    public Vector2 MinAnchor;
    public Vector2 MaxAnchor;

    #region Public

    public void Apply( RectTransform t )
    {
        t.anchorMin = MinAnchor;
        t.anchorMax = MaxAnchor;
    }

    #endregion
}
