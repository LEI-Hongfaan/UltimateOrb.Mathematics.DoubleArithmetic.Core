# UltimateOrb.Mathematics.DoubleArithmetic.Core

Provides static methods to support Int128 and UInt128.

[![Version](https://img.shields.io/nuget/vpre/UltimateOrb.Mathematics.DoubleArithmetic.Core.svg)](https://www.nuget.org/packages/UltimateOrb.Mathematics.DoubleArithmetic.Core)
[![NuGet download count](https://img.shields.io/nuget/dt/UltimateOrb.Mathematics.DoubleArithmetic.Core.svg)](https://www.nuget.org/packages/UltimateOrb.Mathematics.DoubleArithmetic.Core)

[![Join the chat at https://gitter.im/UltimateOrb-Working-Group/PublicMain](https://badges.gitter.im/UltimateOrb-Working-Group/PublicMain.svg)](https://gitter.im/UltimateOrb-Working-Group/PublicMain?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

### Getting Started

#### Java on IKVM.NET
```java
import java.lang.*;
import cli.UltimateOrb.Mathematics.DoubleArithmetic;

public class Program {

    public static void main(String[] args) {
        long first_hi = 1;
        long first_lo = 2;
        long second_hi = 3;
        long second_lo = 1;
        long[] ref_result_hi = new long[1];
        long result_lo = DoubleArithmetic.MultiplyUnchecked(first_lo, first_hi, second_lo, second_hi, ref_result_hi);
        long result_hi = ref_result_hi[0];
        System.out.println(((Long) result_hi).toString());
        System.out.println(((Long) result_lo).toString());
        /*
        0x00000000_00000001_00000000_00000002 * 0x00000000_00000003_00000000_00000001
         == 0x00000000_00000000_00000000_00000003_00000000_00000007_00000000_00000002
                                                  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        Output:
        7
        2
        */
    }
}
```

### Common Issues and FAQs

#### Conditional Compilation Symbols Not Working

See [this post](https://stackoverflow.com/questions/38040466/conditional-compilation-symbol-for-net-core-class-library).

### License

UltimateOrb.Mathematics.DoubleArithmetic.Core is licensed under the [MIT license](LICENSE).
