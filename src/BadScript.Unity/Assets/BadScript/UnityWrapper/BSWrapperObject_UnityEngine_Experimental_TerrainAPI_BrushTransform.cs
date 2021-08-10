using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform : BSWrapperObject < BrushTransform >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_TerrainAPI_BrushTransform( BrushTransform obj ) : base( obj )
        {
            m_Properties["brushOrigin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.brushOrigin ),
                null );

            m_Properties["brushU"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.brushU ),
                null );

            m_Properties["brushV"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.brushV ),
                null );

            m_Properties["targetOrigin"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.targetOrigin ),
                null );

            m_Properties["targetX"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.targetX ),
                null );

            m_Properties["targetY"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector2( m_InternalObject.targetY ),
                null );

            m_Properties["ToBrushUV"] = new BSFunctionReference(
                new BSFunction(
                    "function ToBrushUV(targetXY)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.ToBrushUV( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
                    1 ) );

            m_Properties["FromBrushUV"] = new BSFunctionReference(
                new BSFunction(
                    "function FromBrushUV(brushUV)",
                    a => new BSWrapperObject_UnityEngine_Vector2(
                        m_InternalObject.FromBrushUV( WrapperHelper.UnwrapObject < Vector2 >( a[0] ) ) ),
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
