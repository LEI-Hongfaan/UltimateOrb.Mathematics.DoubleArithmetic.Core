﻿using System;

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = UInt64;
	using HIntT = UInt64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? unchecked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? unchecked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = UInt64;
	using HIntT = Int64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? unchecked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? unchecked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = Int64;
	using HIntT = UInt64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? unchecked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? unchecked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;
	
	using LIntT = Int64;
	using HIntT = Int64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? unchecked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT IncreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(++value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = (~(LIntT)0 == value_lo ? checked(++result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}


		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnchecked(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((HIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? unchecked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseSigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((IntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}

		[System.CLSCompliantAttribute(true)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static LIntT DecreaseUnsigned(LIntT value_lo, HIntT value_hi, out HIntT result_hi) {
			var result_lo_ = unchecked(--value_lo);
			var result_hi_ = unchecked((UIntT)value_hi);
			result_hi_ = ((LIntT)0 == value_lo ? checked(--result_hi_) : result_hi_);
			result_hi = unchecked((HIntT)result_hi_);
			return result_lo_;
		}
	}
}

namespace UltimateOrb.Mathematics {
	using UInt = UInt32;
	using ULong = UInt64;
	using Int = Int32;
	using Long = Int64;

	using Math = UltimateOrb.Internal.System.Math;

	using IntT = Int64;
	using UIntT = UInt64;

	public static partial class DoubleArithmetic {

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static UIntT Increase(UIntT value_lo, UIntT value_hi, out UIntT result_hi) {
			return IncreaseUnsigned(value_lo, value_hi, out result_hi);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static UIntT Increase(UIntT value_lo, IntT value_hi, out IntT result_hi) {
			return IncreaseSigned(value_lo, value_hi, out result_hi);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static UIntT Decrease(UIntT value_lo, UIntT value_hi, out UIntT result_hi) {
			return DecreaseUnsigned(value_lo, value_hi, out result_hi);
		}

		[System.CLSCompliantAttribute(false)]
		[System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static UIntT Decrease(UIntT value_lo, IntT value_hi, out IntT result_hi) {
			return DecreaseSigned(value_lo, value_hi, out result_hi);
		}
	}
}