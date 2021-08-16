using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_Font : BSWrapperObject < Font >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Font( Font obj ) : base( obj )
        {
            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["dynamic"] = new BSReflectionReference(
                () => m_InternalObject.dynamic ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["ascent"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ascent ),
                null );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                null );

            m_Properties["lineHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineHeight ),
                null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["HasCharacter"] = new BSFunctionReference(
                new BSFunction(
                    "function HasCharacter(c)",
                    a => m_InternalObject.HasCharacter( WrapperHelper.UnwrapObject < char >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["RequestCharactersInTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function RequestCharactersInTexture(characters, size)",
                    a =>
                    {
                        m_InternalObject.RequestCharactersInTexture(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["RequestCharactersInTexture"] = new BSFunctionReference(
                new BSFunction(
                    "function RequestCharactersInTexture(characters)",
                    a =>
                    {
                        m_InternalObject.RequestCharactersInTexture( WrapperHelper.UnwrapObject < string >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_Properties["GetInstanceID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetInstanceID()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetInstanceID() ),
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
