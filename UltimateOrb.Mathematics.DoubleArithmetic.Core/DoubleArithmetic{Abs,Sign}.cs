﻿using System;

namespace UltimateOrb.Mathematics {

    using UInt = UInt32;
    using ULong = UInt64;
    using Int = Int32;
    using Long = Int64;

    using UInt_Misc = Internal.SizeOfModule.UInt32;
    using ULong_Misc = Internal.SizeOfModule.UInt64;
    using Int_Misc = Internal.SizeOfModule.Int32;
    using Long_Misc = Internal.SizeOfModule.Int64;

    using Math = UltimateOrb.Internal.System.Math;
    using MathEx = DoubleArithmetic;

    public static partial class DoubleArithmetic {

        /// <summary>
        ///     <para>
        ///         Computes the absolute value of the specified value of a signed operand with double-precision data.
        ///         The result is an unsigned value with double-precision data.
        ///     </para>
        /// </summary>
        /// <param name="value_lo">
        ///     <para>The <c>lo</c> bits of the double-precision data of the operand.</para>
        /// </param>
        /// <param name="value_hi">
        ///     <para>The <c>hi</c> bits of the double-precision data of the operand.</para>
        /// </param>
        /// <param name="result_hi">
        ///     <para>The <c>hi</c> bits of the double-precision data of the result.</para>
        /// </param>
        /// <returns>
        ///     <para>The <c>lo</c> bits of the double-precision data of the result.</para>
        /// </returns>
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong AbsSignedAsUnsigned(ULong value_lo, Long value_hi, out ULong result_hi) {
            unchecked {
                if (0 > (Long)value_hi) {
                    return MathEx.NegateUnchecked(value_lo, (ULong)value_hi, out result_hi);
                }
                result_hi = (ULong)value_hi;
                return value_lo;
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static int Sign(ULong value_lo, Long value_hi) {
            unchecked {
                if (0 > value_hi) {
                    return -1;
                }
                if (0 != value_hi || 0 != value_lo) {
                    return 1;
                }
                return 0;
            }
        }
    }
}