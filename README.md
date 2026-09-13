<div align="center">

# FibApp

**Generate a `1, 2, 3, 5, …` sequence and inspect threshold statistics.**

`C#` · `.NET 8` · `BigInteger`

</div>

FibApp is a compact console application built around a reusable `FibonacciCalculator`. It lists every sequence value up to a chosen threshold, returns the largest included value and term count, and can produce the same statistics across an inclusive threshold range.

## Run

Install the .NET 8 SDK, then:

```bash
dotnet run
```

The program prompts for:

1. A single threshold
2. The start and end of an inclusive range

Example output shape:

```text
Sequence ≤ 20: 1 2 3 5 8 13
Max ≤ 20: 13
Count: 6

Threshold | MaxFib | Count
       18 |     13 |     6
       19 |     13 |     6
       20 |     13 |     6
```

## Design

- `FibonacciCalculator.Generate` returns the bounded sequence.
- `Stats` returns the final value and number of terms.
- `StatsRange` fills aligned arrays for every threshold in a range.
- `BigInteger` avoids overflow for large values.

This project intentionally starts with `1, 2`; it is a Fibonacci-like sequence rather than the conventional `0, 1` definition.

## License

No license is currently declared. All rights are reserved by default.
