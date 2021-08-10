using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextGenerationSettings : BSWrapperObject < TextGenerationSettings >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextGenerationSettings( TextGenerationSettings obj ) : base( obj )
        {
            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["lineSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineSpacing ),
                x => m_InternalObject.lineSpacing = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["richText"] = new BSReflectionReference(
                () => m_InternalObject.richText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.richText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["scaleFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scaleFactor ),
                x => m_InternalObject.scaleFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["alignByGeometry"] = new BSReflectionReference(
                () => m_InternalObject.alignByGeometry ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alignByGeometry = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["resizeTextForBestFit"] = new BSReflectionReference(
                () => m_InternalObject.resizeTextForBestFit ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.resizeTextForBestFit = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["resizeTextMinSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.resizeTextMinSize ),
                x => m_InternalObject.resizeTextMinSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["resizeTextMaxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.resizeTextMaxSize ),
                x => m_InternalObject.resizeTextMaxSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["updateBounds"] = new BSReflectionReference(
                () => m_InternalObject.updateBounds ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.updateBounds = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["generationExtents"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.generationExtents ),
                x => m_InternalObject.generationExtents = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["pivot"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.pivot ),
                x => m_InternalObject.pivot = WrapperHelper.UnwrapObject < Vector2 >( x ) );

            m_Properties["generateOutOfBounds"] = new BSReflectionReference(
                () => m_InternalObject.generateOutOfBounds ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.generateOutOfBounds = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < TextGenerationSettings >( a[0] ) )
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
