#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QSharpApplication1", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs", 171L, 7L, 5L)]
[assembly: OperationDeclaration("Quantum.QSharpApplication1", "BellTest (count : Int, initial : Result) : (Int, Int)", new string[] { }, "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs", 409L, 19L, 5L)]
#line hidden
namespace Quantum.QSharpApplication1
{
    public class Set : Operation<(Result,Qubit), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Result,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.QSharpApplication1.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (desired,q1) = _args;
#line 10 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    var current = M.Apply<Result>(q1);
#line 11 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    if ((desired != current))
                    {
#line 13 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q1);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.QSharpApplication1.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class BellTest : Operation<(Int64,Result), (Int64,Int64)>
    {
        public BellTest(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Release), typeof(Quantum.QSharpApplication1.Set) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get
            {
                return this.Factory.Get<ICallable<(Result,Qubit), QVoid>, Quantum.QSharpApplication1.Set>();
            }
        }

        public override Func<(Int64,Result), (Int64,Int64)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.QSharpApplication1.BellTest", OperationFunctor.Body, _args);
                var __result__ = default((Int64,Int64));
                try
                {
                    var (count,initial) = _args;
#line 22 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    var numOnes = 0L;
#line 23 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
#line 25 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    foreach (var test in new Range(1L, count))
                    {
#line 27 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        Set.Apply((initial, qubits[0L]));
#line 28 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        Set.Apply((Result.Zero, qubits[1L]));
#line 30 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
#line 31 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
#line 32 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        var res = M.Apply<Result>(qubits[0L]);
                        // Count the number of ones we saw:
#line 35 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                        if ((res == Result.One))
                        {
#line 37 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                            numOnes = (numOnes + 1L);
                        }
                    }

#line 40 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    Set.Apply((Result.Zero, qubits[0L]));
#line 41 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    Set.Apply((Result.Zero, qubits[1L]));
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = ((count - numOnes), numOnes);
                    // Return number of times we saw a |0> and number of times we saw a |1>
#line 44 "D:\\Users\\Died.Liu\\source\\repos\\QSharpApplication1\\QSharpApplication1\\Operation.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.QSharpApplication1.BellTest", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Result initial)
        {
            return __m__.Run<BellTest, (Int64,Result), (Int64,Int64)>((count, initial));
        }
    }
}