using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.Core.Utilities.Results;

namespace RentACar.Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] args)
        {
            foreach (var arg in args)
            {
                if (!arg.Success)
                {
                    return arg;
                }
            }

            return null;
        }
    }
}
