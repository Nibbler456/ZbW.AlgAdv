using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet_Demo {
    [MemoryDiagnoser]
    [ShortRunJob]
    public class ImageBenchmarks {
        private int[,] _pixels = new int[0, 0];

        [Params(32, 512, 4096)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup() {
            // Vereinfachtes Graustufenbild: Helligkeiten von 0 bis 255.
            // Fuer die leicht lesbare Demo speichern wir jeden Wert als int.
            var random = new Random(42);
            _pixels = new int[Size, Size];
            long expected = 0;

            for (int row = 0; row < Size; row++) {
                for (int column = 0; column < Size; column++) {
                    int value = random.Next(256);
                    _pixels[row, column] = value;
                    expected += value;
                }
            }

            // Kontrolliert beide Ergebnisse ausserhalb der Zeitmessung.
            if (RowsFirst() != expected || ColumnsFirst() != expected) {
                throw new InvalidOperationException("Die Pixelsummen sind falsch.");
            }
        }

        [Benchmark(Baseline = true)]
        public long RowsFirst() {
            int size = Size;
            long sum = 0;

            for (int row = 0; row < size; row++) {
                for (int column = 0; column < size; column++) {
                    sum += _pixels[row, column];
                }
            }

            return sum;
        }

        [Benchmark]
        public long ColumnsFirst() {
            int size = Size;
            long sum = 0;

            for (int column = 0; column < size; column++) {
                for (int row = 0; row < size; row++) {
                    sum += _pixels[row, column];
                }
            }

            return sum;
        }
    }
}
