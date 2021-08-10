using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.WSA;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WSA_SecondaryTileData : BSWrapperObject < SecondaryTileData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WSA_SecondaryTileData( SecondaryTileData obj ) : base( obj )
        {
            m_Properties["backgroundColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color32( m_InternalObject.backgroundColor ),
                x => m_InternalObject.backgroundColor = WrapperHelper.UnwrapObject < Color32 >( x ) );

            m_Properties["arguments"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.arguments ),
                x => m_InternalObject.arguments = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["backgroundColorSet"] = new BSReflectionReference(
                () => m_InternalObject.backgroundColorSet ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.backgroundColorSet = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["displayName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.displayName ),
                x => m_InternalObject.displayName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["lockScreenBadgeLogo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.lockScreenBadgeLogo ),
                x => m_InternalObject.lockScreenBadgeLogo = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["lockScreenDisplayBadgeAndTileText"] = new BSReflectionReference(
                () => m_InternalObject.lockScreenDisplayBadgeAndTileText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.lockScreenDisplayBadgeAndTileText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["phoneticName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.phoneticName ),
                x => m_InternalObject.phoneticName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["roamingEnabled"] = new BSReflectionReference(
                () => m_InternalObject.roamingEnabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.roamingEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["showNameOnSquare150x150Logo"] = new BSReflectionReference(
                () => m_InternalObject.showNameOnSquare150x150Logo ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.showNameOnSquare150x150Logo = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["showNameOnSquare310x310Logo"] = new BSReflectionReference(
                () => m_InternalObject.showNameOnSquare310x310Logo ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.showNameOnSquare310x310Logo = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["showNameOnWide310x150Logo"] = new BSReflectionReference(
                () => m_InternalObject.showNameOnWide310x150Logo ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.showNameOnWide310x150Logo = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["square150x150Logo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.square150x150Logo ),
                x => m_InternalObject.square150x150Logo = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["square30x30Logo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.square30x30Logo ),
                x => m_InternalObject.square30x30Logo = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["square310x310Logo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.square310x310Logo ),
                x => m_InternalObject.square310x310Logo = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["square70x70Logo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.square70x70Logo ),
                x => m_InternalObject.square70x70Logo = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["tileId"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.tileId ),
                x => m_InternalObject.tileId = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["wide310x150Logo"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.wide310x150Logo ),
                x => m_InternalObject.wide310x150Logo = WrapperHelper.UnwrapObject < string >( x ) );

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
