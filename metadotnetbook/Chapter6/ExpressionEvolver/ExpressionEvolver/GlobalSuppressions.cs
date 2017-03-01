// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project. 
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc. 
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File". 
// You do not need to add suppressions to this file manually. 

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ExpressionEvolver")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#ChromosomeLength")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#GetNode(System.Linq.Expressions.Expression,System.Int32,System.Int32&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#Reduce(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames", MessageId = "2#", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#Replace(System.Linq.Expressions.Expression,System.Linq.Expressions.Expression,System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Op", Scope = "type", Target = "ExpressionEvolver.ExprOp")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Expr", Scope = "type", Target = "ExpressionEvolver.ExprOp")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "ExpressionEvolver.ExprOp.#.cctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "expr", Scope = "member", Target = "ExpressionEvolver.ExprOp.#IsBinary(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "expr", Scope = "member", Target = "ExpressionEvolver.ExprOp.#IsUnary(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible", Scope = "member", Target = "ExpressionEvolver.ExprOp.#Visit")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "b", Scope = "member", Target = "ExpressionEvolver.ExprOp.#VisitBinding(System.Func`2<System.Linq.Expressions.Expression,System.Linq.Expressions.Expression>,System.Linq.Expressions.MemberBinding)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#MyReduce(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "ExpressionEvolver.FuncOp.#Chain`2(System.Func`2<!!0,!!1>,System.Func`4<System.Func`2<!!0,!!1>,System.Func`2<!!0,!!1>,!!0,!!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ReplacementVisitor+ParameterReplacementVisitor.#VisitBinary(System.Linq.Expressions.BinaryExpression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#.ctor(System.Func`2<System.Double,System.Double>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#.ctor(System.Func`2<System.Double,System.Double>,System.Int32,System.Double)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#.ctor(System.Collections.ObjectModel.ReadOnlyCollection`1<ExpressionEvolver.ExpressionEvolverResult>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "ExpressionEvolver.RandomExpressionGenerator.#ConstantVariance")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "ExpressionEvolver.RandomExpressionGenerator.#GetConstant()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#Crossover(System.Collections.ObjectModel.ReadOnlyCollection`1<GeneticAlgorithm.Chromosome`1<System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#.ctor(System.Collections.ObjectModel.ReadOnlyCollection`1<ExpressionEvolver.ExpressionEvolverResult>,Spackle.SecureRandom)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#FitnessEvaluator(System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#Mutator(System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#SelectFittestChildren(GeneticAlgorithm.Population`1<System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#SelectParents(GeneticAlgorithm.Population`1<System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#Terminator(GeneticAlgorithm.Population`1<System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#Compress(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#GetNodeCount(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "ExpressionEvolver.ExpressionExtensions.#IsValid(System.Linq.Expressions.Expression)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "nodeCount", Scope = "member", Target = "ExpressionEvolver.ExpressionEvolverGeneticAlgorithmParameters.#FitnessEvaluator(System.Linq.Expressions.Expression`1<System.Func`2<System.Double,System.Double>>)")]