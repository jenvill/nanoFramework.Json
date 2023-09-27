//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Json.Converters
{
    internal sealed class EnumConverter : IConverter
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string ToJson(object value) => ((int)value).ToString();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public object ToType(object value) => (int)value;
    }
}
