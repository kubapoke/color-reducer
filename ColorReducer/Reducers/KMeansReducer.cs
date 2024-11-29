using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorReducer.Reducers
{
    internal class KMeansReducer : Reducer
    {
        protected int _eps;

        public KMeansReducer(int amount, int eps) : base(amount)
        {
            _eps = eps;
        }

        protected override void GeneratePalette(DirectBitmap bitmap)
        {
            throw new NotImplementedException();
        }
    }
}
