using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    class StringGenerator : IGenerator
    {
        public Type GeneratorType => typeof(string);

        public object GetRandomValue()
        {
            Random random = new Random();
            int length = random.Next(byte.MaxValue);
            StringBuilder builder = new StringBuilder();
            CharGenerator chr = new CharGenerator();
            for (int i = 0; i < length; i++)
            {
                builder.Append(chr.GetRandomValue());
            }
            return builder.ToString();
        }
    }
}
