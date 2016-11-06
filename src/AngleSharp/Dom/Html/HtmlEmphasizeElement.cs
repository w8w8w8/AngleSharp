﻿namespace AngleSharp.Dom.Html
{
    using System;

    /// <summary>
    /// The em HTML element.
    /// </summary>
    sealed class HtmlEmphasizeElement : HtmlElement
    {
        public HtmlEmphasizeElement(Document owner, String prefix = null)
            : base(owner, TagNames.Em, prefix, NodeFlags.HtmlFormatting)
        {
        }
    }
}
