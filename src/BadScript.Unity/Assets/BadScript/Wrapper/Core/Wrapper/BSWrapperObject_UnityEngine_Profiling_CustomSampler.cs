using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Profiling;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Profiling_CustomSampler : BSWrapperObject < CustomSampler >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Profiling_CustomSampler( CustomSampler obj ) : base( obj )
        {
            m_Properties["isValid"] = new BSReflectionReference(
                () => m_InternalObject.isValid ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["Begin"] = new BSFunctionReference(
                new BSFunction(
                    "function Begin()",
                    a =>
                    {
                        m_InternalObject.Begin();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Begin"] = new BSFunctionReference(
                new BSFunction(
                    "function Begin(targetObject)",
                    a =>
                    {
                        m_InternalObject.Begin( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["End"] = new BSFunctionReference(
                new BSFunction(
                    "function End()",
                    a =>
                    {
                        m_InternalObject.End();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["GetRecorder"] = new BSFunctionReference(
                new BSFunction(
                    "function GetRecorder()",
                    a => new BSWrapperObject_UnityEngine_Profiling_Recorder( m_InternalObject.GetRecorder() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
