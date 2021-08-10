using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LocalizationAsset : BSWrapperObject < LocalizationAsset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LocalizationAsset( LocalizationAsset obj ) : base( obj )
        {
            m_Properties["localeIsoCode"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.localeIsoCode ),
                x => m_InternalObject.localeIsoCode = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["isEditorAsset"] = new BSReflectionReference(
                () => m_InternalObject.isEditorAsset ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isEditorAsset = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["GetLocalizedString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLocalizedString(original)",
                    a => new BSObject(
                        m_InternalObject.GetLocalizedString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
