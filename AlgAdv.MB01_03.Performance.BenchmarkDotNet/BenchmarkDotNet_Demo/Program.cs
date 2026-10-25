using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet_Demo {
    public class Program {
        public static void Main(string[] args) {
            //var summary = BenchmarkRunner.Run<Md5VsSha256>();
            BenchmarkRunner.Run<ImageBenchmarks>();
        }
       
    }
}
