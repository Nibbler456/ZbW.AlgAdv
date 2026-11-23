```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26300.9711)
AMD Ryzen AI 9 HX PRO 370 w/ Radeon 890M 2.00GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.401
  [Host]   : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  ShortRun : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | Size | Mean            | Error           | StdDev        | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------- |----- |----------------:|----------------:|--------------:|------:|--------:|----------:|------------:|
| **RowsFirst**    | **32**   |        **642.8 ns** |         **4.04 ns** |       **0.22 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| ColumnsFirst | 32   |        646.1 ns |        41.85 ns |       2.29 ns |  1.01 |    0.00 |         - |          NA |
|              |      |                 |                 |               |       |         |           |             |
| **RowsFirst**    | **512**  |    **137,389.3 ns** |     **6,598.75 ns** |     **361.70 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| ColumnsFirst | 512  |    212,861.8 ns |    27,069.68 ns |   1,483.78 ns |  1.55 |    0.01 |         - |          NA |
|              |      |                 |                 |               |       |         |           |             |
| **RowsFirst**    | **4096** | **10,981,517.2 ns** | **2,655,514.99 ns** | **145,557.74 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| ColumnsFirst | 4096 | 74,906,538.1 ns | 8,865,224.06 ns | 485,932.85 ns |  6.82 |    0.09 |         - |          NA |
