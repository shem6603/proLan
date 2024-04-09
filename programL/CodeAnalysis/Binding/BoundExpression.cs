using System;
using programL.CodeAnalysis.Symbols;
using programL.CodeAnalysis.Syntax;

namespace programL.CodeAnalysis.Binding
{
    internal abstract class BoundExpression : BoundNode
    {
        protected BoundExpression(SyntaxNode syntax)
            : base(syntax)
        {
        }

        public abstract TypeSymbol Type { get; }
        public virtual BoundConstant? ConstantValue => null;
    }
}
