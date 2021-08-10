using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Animations;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Animations_PropertySceneHandle : BSWrapperObject < PropertySceneHandle >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Animations_PropertySceneHandle( PropertySceneHandle obj ) : base( obj )
        {
            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid(stream)",
                    a => m_InternalObject.IsValid( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["IsResolved"] = new BSFunctionReference(
                new BSFunction(
                    "function IsResolved(stream)",
                    a => m_InternalObject.IsResolved( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetFloat"] = new BSFunctionReference(
                new BSFunction(
                    "function GetFloat(stream)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetFloat(
                            WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetInt"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInt(stream)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetInt( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetBool"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBool(stream)",
                    a => m_InternalObject.GetBool( WrapperHelper.UnwrapObject < AnimationStream >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
