using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Threading_Tasks_TaskScheduler() : base(typeof(System.Threading.Tasks.TaskScheduler))
        {
            m_StaticProperties["Default"] = new BSReflectionReference(() => new BSWrapperObject_System_Threading_Tasks_TaskScheduler(System.Threading.Tasks.TaskScheduler.Default), null);
            m_StaticProperties["Current"] = new BSReflectionReference(() => new BSWrapperObject_System_Threading_Tasks_TaskScheduler(System.Threading.Tasks.TaskScheduler.Current), null);
            m_StaticProperties["FromCurrentSynchronizationContext"] = new BSFunctionReference(new BSFunction("function FromCurrentSynchronizationContext()", a => new BSWrapperObject_System_Threading_Tasks_TaskScheduler(System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext()), 0));

        }
    }

}