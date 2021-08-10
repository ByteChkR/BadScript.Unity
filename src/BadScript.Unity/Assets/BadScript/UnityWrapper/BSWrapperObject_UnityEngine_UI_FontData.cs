using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_FontData : BSWrapperObject < FontData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_FontData( FontData obj ) : base( obj )
        {
            m_Properties["font"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Font( m_InternalObject.font ),
                x => m_InternalObject.font = WrapperHelper.UnwrapObject < Font >( x ) );

            m_Properties["fontSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSize ),
                x => m_InternalObject.fontSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["bestFit"] = new BSReflectionReference(
                () => m_InternalObject.bestFit ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.bestFit = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["minSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.minSize ),
                x => m_InternalObject.minSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["maxSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.maxSize ),
                x => m_InternalObject.maxSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["alignByGeometry"] = new BSReflectionReference(
                () => m_InternalObject.alignByGeometry ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.alignByGeometry = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["richText"] = new BSReflectionReference(
                () => m_InternalObject.richText ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.richText = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["lineSpacing"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineSpacing ),
                x => m_InternalObject.lineSpacing = WrapperHelper.UnwrapObject < float >( x ) );

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
