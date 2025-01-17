// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Metric computation method to use for validation metrics in image tasks.
    /// Serialized Name: ValidationMetricType
    /// </summary>
    public readonly partial struct ValidationMetricType : IEquatable<ValidationMetricType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ValidationMetricType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValidationMetricType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string CocoValue = "Coco";
        private const string VocValue = "Voc";
        private const string CocoVocValue = "CocoVoc";

        /// <summary>
        /// No metric.
        /// Serialized Name: ValidationMetricType.None
        /// </summary>
        public static ValidationMetricType None { get; } = new ValidationMetricType(NoneValue);
        /// <summary>
        /// Coco metric.
        /// Serialized Name: ValidationMetricType.Coco
        /// </summary>
        public static ValidationMetricType Coco { get; } = new ValidationMetricType(CocoValue);
        /// <summary>
        /// Voc metric.
        /// Serialized Name: ValidationMetricType.Voc
        /// </summary>
        public static ValidationMetricType Voc { get; } = new ValidationMetricType(VocValue);
        /// <summary>
        /// CocoVoc metric.
        /// Serialized Name: ValidationMetricType.CocoVoc
        /// </summary>
        public static ValidationMetricType CocoVoc { get; } = new ValidationMetricType(CocoVocValue);
        /// <summary> Determines if two <see cref="ValidationMetricType"/> values are the same. </summary>
        public static bool operator ==(ValidationMetricType left, ValidationMetricType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValidationMetricType"/> values are not the same. </summary>
        public static bool operator !=(ValidationMetricType left, ValidationMetricType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ValidationMetricType"/>. </summary>
        public static implicit operator ValidationMetricType(string value) => new ValidationMetricType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValidationMetricType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValidationMetricType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
