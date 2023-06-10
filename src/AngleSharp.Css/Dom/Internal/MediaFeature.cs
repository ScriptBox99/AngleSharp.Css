﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Text;
    using System;
    using System.IO;

    /// <summary>
    /// Represents a feature expression within a media query.
    /// </summary>
    sealed class MediaFeature : IMediaFeature
    {
        #region Fields

        private readonly Boolean _min;
        private readonly Boolean _max;
        private readonly String _name;
        private readonly ICssValue _value;

        #endregion

        #region ctor

        internal MediaFeature(String name)
            : this(name, null)
        {}

        internal MediaFeature(String name, ICssValue value)
        {
            _name = name;
            _value = value;
            _min = name.StartsWith("min-");
            _max = name.StartsWith("max-");
        }

        #endregion

        #region Properties

        public String Name => _name;

        public Boolean IsMinimum => _min;

        public Boolean IsMaximum => _max;

        public String Value => _value?.CssText ?? String.Empty;

        public Boolean HasValue => _value != null;

        #endregion

        #region Methods

        public void ToCss(TextWriter writer, IStyleFormatter formatter)
        {
            writer.Write(Symbols.RoundBracketOpen);
            writer.Write(_name);

            if (_value != null)
            {
                writer.Write(": ");
                writer.Write(Value);
            }

            writer.Write(Symbols.RoundBracketClose);
        }

        #endregion
    }
}
