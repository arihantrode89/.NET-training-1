using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Expression_tree_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Multiply, Expression.Constant(10), Expression.Constant(2));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Divide, Expression.Constant(10), Expression.Constant(5));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, Expression.Constant(10), Expression.Constant(1));
            BinaryExpression b4 = Expression.MakeBinary(ExpressionType.Add,b1,b2);
            BinaryExpression b5 = Expression.MakeBinary(ExpressionType.Subtract,b4,b3);

            int result = Expression.Lambda<Func<int>>(b5).Compile()();
            Console.WriteLine(result);

            Expression<Func<int,bool>> lambda = num=>num < 6;
            bool numres = lambda.Compile()(8);
            Console.WriteLine(numres);

            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            Expression<Func<List<int>, dynamic>> lambda1 = s => s.Where(s1=>s1>6);
            var rr = list.Where(s=>s%2==0);
            var rr1 = lambda1.Compile()(list);
            var rr2 = lambda1.Compile()(rr.ToList());
            foreach (int i in rr1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
