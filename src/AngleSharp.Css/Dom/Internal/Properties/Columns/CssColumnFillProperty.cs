﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Css;
    using AngleSharp.Css.Converters;
    using static ValueConverters;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/column-fill
    /// Gets if the columns should be filled uniformly.
    /// </summary>
    sealed class CssColumnFillProperty : CssProperty
    {
        #region Fields

        private static readonly IValueConverter StyleConverter = Or(ColumnFillConverter, AssignInitial(true));

        #endregion

        #region ctor

        internal CssColumnFillProperty()
            : base(PropertyNames.ColumnFill)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion
    }
}