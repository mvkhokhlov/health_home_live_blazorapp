﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HHL.WebApp.Components.Shared
{

    public class InputCustomTime<T> : InputBase<T>
    {
        const string dateFormat = ""; // Compatible with HTML date inputs

        [Parameter] string ParsingErrorMessage { get; set; } = "The {0} field must be a date.";
        [Parameter] protected string Placeholder { get; private set; }
        /// <inheritdoc />
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "time");
            builder.AddAttribute(2, "id", Id);
            builder.AddAttribute(3, "class", CssClass);
            builder.AddAttribute(4, "value", BindMethods.GetValue(CurrentValueAsString));
            builder.AddAttribute(5, "onchange", BindMethods.SetValueHandler(__value => CurrentValueAsString = __value, CurrentValueAsString));
            if (!string.IsNullOrWhiteSpace(Placeholder))
            {
                builder.AddAttribute(6, "placeholder", Placeholder);
            }
            builder.CloseElement();
        }

        /// <inheritdoc />
        protected override string FormatValueAsString(T value)
        {
            switch (value)
            {
                case TimeSpan dateTimeValue:
                    return dateTimeValue.ToString();
                default:
                    return string.Empty; // Handles null for Nullable<DateTime>, etc.
            }
        }

        /// <inheritdoc />
        protected override bool TryParseValueFromString(string value, out T result, out string validationErrorMessage)
        {
            // Unwrap nullable types. We don't have to deal with receiving empty values for nullable
            // types here, because the underlying InputBase already covers that.
            var targetType = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);

            bool success;
            if (targetType == typeof(TimeSpan))
            {
                success = TryParseDateTime(value, out result);
            }
            else
            {
                throw new InvalidOperationException($"The type '{targetType}' is not a supported date type.");
            }

            if (success)
            {
                validationErrorMessage = null;
                return true;
            }
            else
            {
                validationErrorMessage = string.Format(ParsingErrorMessage, FieldIdentifier.FieldName);
                return false;
            }
        }

        static bool TryParseDateTime(string value, out T result)
        {
            var success = TimeSpan.TryParse(value, out var parsedValue);
            if (success)
            {
                result = (T)(object)parsedValue;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }
    }
}