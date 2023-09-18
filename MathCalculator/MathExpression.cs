﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MathCalculatorAutogenerated;

namespace Antlr.MathCalculator;

internal class MathExpression
{
    private readonly IParseTree parseTree;
    public MathExpression(string str)
    {
        var stream = new AntlrInputStream(str);
        var lexer = new MathCalculatorLexer(stream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new MathCalculatorParser(tokenStream);
        //parser.RemoveErrorListener(ConsoleErrorListener<IToken>.Instance);
        parseTree = parser.numericExpression();
        var parsedExpressions = tokenStream.GetText();
        if (parsedExpressions != str)
            throw new Exception($"Original [{str}] and parsed [{parsedExpressions}] expressions do not match");
    }
    public decimal Calculate(IDictionary<string, decimal> variables,
        IMathCalculatorFunctions functions)
    {
        var visitor = new MathCalculatorVisitor(variables, functions);
        return visitor.Visit(parseTree);
    }
}