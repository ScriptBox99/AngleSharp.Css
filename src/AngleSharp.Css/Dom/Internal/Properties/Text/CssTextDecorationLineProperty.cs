﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Css;
    using AngleSharp.Css.Converters;
    using static ValueConverters;

    /// <summary>
    /// Information:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/text-decoration-line
    /// Gets the enumeration over all selected styles for text decoration
    /// lines.
    /// </summary>
    sealed class CssTextDecorationLineProperty : CssProperty
    {
        #region Fields

        private static readonly IValueConverter ListConverter = Or(TextDecorationLinesConverter, Initial);

        #endregion

        #region ctor

        internal CssTextDecorationLineProperty()
            : base(PropertyNames.TextDecorationLine)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return ListConverter; }
        }

        #endregion
    }
}