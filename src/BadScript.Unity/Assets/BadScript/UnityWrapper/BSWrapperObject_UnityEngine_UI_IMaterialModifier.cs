using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UI_IMaterialModifier : BSWrapperObject < IMaterialModifier >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UI_IMaterialModifier( IMaterialModifier obj ) : base( obj )
        {
            m_Properties["GetModifiedMaterial"] = new BSFunctionReference(
                new BSFunction(
                    "function GetModifiedMaterial(baseMaterial)",
                    a => new BSWrapperObject_UnityEngine_Material(
                        m_InternalObject.GetModifiedMaterial( WrapperHelper.UnwrapObject < Material >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
