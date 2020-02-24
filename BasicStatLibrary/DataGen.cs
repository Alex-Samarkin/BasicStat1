using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using MathNet.Numerics.Random;
using MathNet.Numerics.Distributions;

namespace BasicStatLibrary
{
    public class DataGen
    {
        public int Seed { get; set; }
        public Random random { get; set; } = new Random();
        private int _n;
        public int N=>_n;
        public void Setup(int NewSeed, int NFrom = 250, int NTo = 500, double dataFrom = 170, double dataTo = 210)
        {
            Seed = NewSeed;
            random = new Random(Seed);
            _n = random.Next(NFrom, NTo);
            DataMin = dataFrom;
            DataMax = dataTo;
        }
        public double DataMin { get; set; } = 0;
        public double DataMax { get; set; } = 210;

        public List<double> Items { get; set; } = new List<double>();
        public void Generate()
        {
            double mu = (DataMax + DataMin) / 2.0;
            double sigma = (DataMax - DataMin) / 6.0;
            //Items.AddRange(MathNet.Numerics.Generate.Normal(N,mu,sigma));
            Items.Clear();
            var normal = new Normal(mu, sigma, random);
            var samples = new double[N];
            normal.Samples(samples);
            Items.AddRange(samples);
        }
    }
}
