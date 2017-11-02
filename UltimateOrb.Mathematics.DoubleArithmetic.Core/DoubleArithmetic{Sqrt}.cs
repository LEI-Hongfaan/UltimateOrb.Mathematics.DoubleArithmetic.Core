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

    using Math = System.Math;
    using MathEx = DoubleArithmetic;

    public static partial class DoubleArithmetic {

        /*
        [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
        [System.Runtime.TargetedPatchingOptOutAttribute(null)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        [System.Diagnostics.Contracts.PureAttribute()]
        private static ULong Abs(Long value) {
            unchecked {
                return 0 > value ? (ULong)(-value) : (ULong)value;
            }
        }
        */

        /// <summary>
        ///     <para>
        ///         Returns the square root of the specified value of an operand with double-precision data.
        ///     </para>
        /// </summary>
        /// <param name="lo">
        ///     <para>The <c>lo</c> bits of the double-precision data of the operand.</para>
        /// </param>
        /// <param name="hi">
        ///     <para>The <c>hi</c> bits of the double-precision data of the operand.</para>
        /// </param>
        /// <returns>
        ///     <para>The square root.</para>
        /// </returns>
        /// <remarks>
        ///     <para>The result is rounded towards zero.</para>
        /// </remarks>
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigSqrt(ULong lo, UInt hi) {
            unchecked {
                if (0u == hi) {
                    return Mathematics.Elementary.Math.Sqrt(lo);
                }
                var old = (ULong)Math.Sqrt((0.0 + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1)) + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1))) * hi + lo);
                ULong h;
                var l = MathEx.BigSquare(old, out h);
                l += lo;
                h += hi;
                if (l < lo) {
                    ++h;
                }
                var @new = MathEx.BigDivNoThrow(l, h, old) >> 1;
                l = MathEx.BigSquare(@new, out h);
                if ((h > hi) || ((h == hi) && (l > lo))) {
                    return @new - (ULong)1u;
                } else {
                    return @new;
                }
            }
        }

        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigSqrtRem(ULong lo, UInt hi, out ULong remainder) {
            unchecked {
                if (0u == hi) {
                    return Mathematics.Elementary.Math.SqrtRem(lo, out remainder);
                }
                var old = (ULong)Math.Sqrt((0.0 + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1)) + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1))) * hi + lo);
                ULong h;
                var l = MathEx.BigSquare(old, out h);
                l += lo;
                h += hi;
                if (l < lo) {
                    ++h;
                }
                var @new = MathEx.BigDivNoThrow(l, h, old) >> 1;
                l = MathEx.BigSquare(@new, out h);
                if ((h > hi) || ((h == hi) && (l > lo))) {
                    remainder = lo - l - ((@new << 1) - 1u);
                    return @new - (ULong)1u;
                } else {
                    remainder = lo - l;
                    return @new;
                }
            }
        }

        /// <summary>
        ///     <para>Returns the square root of a specified value of an operand with double-precision data.</para>
        /// </summary>
        /// <param name="lo">
        ///     <para>The <c>lo</c> bits of the radicand.</para>
        /// </param>
        /// <param name="hi">
        ///     <para>The <c>hi</c> bits of the radicand.</para>
        /// </param>
        /// <returns>
        ///     <para>The square root.</para>
        /// </returns>
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static ULong BigSqrt(ULong lo, ULong hi) {
            unchecked {
                if (0u == hi) {
                    return Mathematics.Elementary.Math.Sqrt(lo);
                }
                if (hi <= ~(ULong)0 >> 2) {
                    var old = (ULong)Math.Sqrt((0.0 + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1)) + ((ULong)1u << (ULong_Misc.BitSizeAsIntUnchecked - 1))) * hi + lo);
                    ULong h;
                    var l = MathEx.BigSquare(old, out h);
                    l += lo;
                    h += hi;
                    if (l < lo) {
                        ++h;
                    }
                    var @new = MathEx.BigDivNoThrow(l, h, old) >> 1;
                    l = MathEx.BigSquare(@new, out h);
                    if ((h > hi) || ((h == hi) && (l > lo))) {
                        return @new - (ULong)1u;
                    } else {
                        return @new;
                    }
                }
                {
                    if (hi == ~(ULong)0) {
                        return ~(ULong)0;
                    }
                    var old = (ULong)(((ULong)1u << (UInt_Misc.BitSizeAsIntUnchecked - 1)) * Math.Sqrt(hi));
                    var a = lo;
                    lo = (lo >> 2) | (hi << (ULong_Misc.BitSizeAsIntUnchecked - 2));
                    hi = hi >> 2;
                    ULong h;
                    var l = MathEx.BigSquare(old, out h);
                    l += lo;
                    h += hi;
                    if (l < lo) {
                        ++h;
                    }
                    var @new = MathEx.BigDivNoThrow(l, h, old) >> 1;
                    l = MathEx.BigSquare(@new, out h);
                    if ((h > hi) || ((h == hi) && (l > lo))) {
                        --@new;
                        @new <<= 1;
                        hi = (hi << 2) | (lo >> (ULong_Misc.BitSizeAsIntUnchecked - 2));
                        lo = a;
                        a = (@new << 1) + 1u;
                        var b = l;
                        l <<= 2;
                        h = (h << 2) + (ULong)(((l < a) ? -1 : 0) + ((0 > (Long)@new) ? -1 : 0) + ((int)(b >> (ULong_Misc.BitSizeAsIntUnchecked - 2))));
                        l -= a;
                    } else {
                        @new <<= 1;
                        hi = (hi << 2) | (lo >> (ULong_Misc.BitSizeAsIntUnchecked - 2));
                        lo = a;
                        a = (@new << 1) + 1u;
                        var b = l;
                        l <<= 2;
                        l += a;
                        h = (h << 2) + (((l < a) ? 1u : 0u) + ((0 > (Long)@new) ? 1u : 0u) + ((uint)(b >> (ULong_Misc.BitSizeAsIntUnchecked - 2))));
                    }
                    if ((h > hi) || ((h == hi) && (l > lo))) {
                    } else {
                        ++@new;
                    }
                    return @new;
                }
            }
        }


        /// <summary>
        ///     <para>Returns the square root of a specified number.</para>
        /// </summary>
        /// <param name="radicand">
        ///     <para>The radicand.</para>
        /// </param>
        /// <returns>
        ///     <para>
        ///         The truncated (upto double precision) value of the positive square root of <paramref name="radicand"/>;
        ///         that is, (of the return value)
        ///         <list type="bullet">
        ///             <item><term>the higher half</term><description>: the integral part of the square root -and-</description></item>
        ///             <item><term>the lower half</term><description>: the fractional part of the square root.</description></item>
        ///         </list>
        ///     </para>
        /// </returns>
        [System.CLSCompliantAttribute(false)]
        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        // ~327. Cyc
        public static ULong SqrtDouble(ULong radicand) {
            unchecked {
                if (0u == radicand) {
                    return 0u;
                }
                /*
                if (radicand <= ~(ULong)0 >> 2) {
                    var old = (ULong)(((ULong)1u << (UInt_Misc.BitSizeAsIntUnchecked - 0)) * Math.Sqrt(radicand));
                    ULong h;
                    var l = MathEx.BigSquare(old, out h);
                    h += radicand;
                    var @new = MathEx.BigDivUnchecked(l, h, old) >> 1;
                    l = MathEx.BigSquare(@new, out h);
                    if ((h > radicand) || ((h == radicand) && (l > 0u))) {
                        return @new - (ULong)1u;
                    } else {
                        return @new;
                    }
                }
                */
                {
                    if (radicand == ~(ULong)0) {
                        return ~(ULong)0;
                    }
                    var old = (ULong)(((ULong)1u << (UInt_Misc.BitSizeAsIntUnchecked - 1)) * Math.Sqrt(radicand));
                    var a = (ULong)0u;
                    var lo = radicand << (ULong_Misc.BitSizeAsIntUnchecked - 2);
                    radicand = radicand >> 2;
                    ULong h;
                    var l = MathEx.BigSquare(old, out h);
                    l += lo;
                    h += radicand;
                    if (l < lo) {
                        ++h;
                    }
                    var @new = MathEx.BigDivNoThrow(l, h, old) >> 1;
                    l = MathEx.BigSquare(@new, out h);
                    if ((h > radicand) || ((h == radicand) && (l > lo))) {
                        --@new;
                        @new <<= 1;
                        radicand = (radicand << 2) | (lo >> (ULong_Misc.BitSizeAsIntUnchecked - 2));
                        lo = a;
                        a = (@new << 1) + 1u;
                        var b = l;
                        l <<= 2;
                        h = (h << 2) + (ULong)(((l < a) ? -1 : 0) + ((0 > (Long)@new) ? -1 : 0) + ((int)(b >> (ULong_Misc.BitSizeAsIntUnchecked - 2))));
                        l -= a;
                    } else {
                        @new <<= 1;
                        radicand = (radicand << 2) | (lo >> (ULong_Misc.BitSizeAsIntUnchecked - 2));
                        lo = a;
                        a = (@new << 1) + 1u;
                        var b = l;
                        l <<= 2;
                        l += a;
                        h = (h << 2) + (((l < a) ? 1u : 0u) + ((0 > (Long)@new) ? 1u : 0u) + ((uint)(b >> (ULong_Misc.BitSizeAsIntUnchecked - 2))));
                    }
                    if ((h > radicand) || ((h == radicand) && (l > lo))) {
                    } else {
                        ++@new;
                    }
                    return @new;
                }
            }
        }
    }
}
