using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AnimationCurve : BSWrapperObject < AnimationCurve >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimationCurve( AnimationCurve obj ) : base( obj )
        {
            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
                null );

            m_Properties["Evaluate"] = new BSFunctionReference(
                new BSFunction(
                    "function Evaluate(time)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.Evaluate( WrapperHelper.UnwrapObject < float >( a[0] ) ) ),
                    1 ) );

            m_Properties["AddKey"] = new BSFunctionReference(
                new BSFunction(
                    "function AddKey(time, value)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.AddKey(
                            WrapperHelper.UnwrapObject < float >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) ) ),
                    2 ) );

            m_Properties["AddKey"] = new BSFunctionReference(
                new BSFunction(
                    "function AddKey(key)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.AddKey( WrapperHelper.UnwrapObject < Keyframe >( a[0] ) ) ),
                    1 ) );

            m_Properties["MoveKey"] = new BSFunctionReference(
                new BSFunction(
                    "function MoveKey(index, key)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.MoveKey(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < Keyframe >( a[1] ) ) ),
                    2 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < AnimationCurve >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
