using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_HumanTrait : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_HumanTrait() : base( typeof( HumanTrait ) )
        {
            m_StaticProperties["MuscleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) HumanTrait.MuscleCount ),
                null );

            m_StaticProperties["BoneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) HumanTrait.BoneCount ),
                null );

            m_StaticProperties["RequiredBoneCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) HumanTrait.RequiredBoneCount ),
                null );

            m_StaticProperties["MuscleFromBone"] = new BSFunctionReference(
                new BSFunction(
                    "function MuscleFromBone(i, dofIndex)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.MuscleFromBone(
                            WrapperHelper.UnwrapObject < int >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["BoneFromMuscle"] = new BSFunctionReference(
                new BSFunction(
                    "function BoneFromMuscle(i)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.BoneFromMuscle( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["RequiredBone"] = new BSFunctionReference(
                new BSFunction(
                    "function RequiredBone(i)",
                    a => HumanTrait.RequiredBone( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetMuscleDefaultMin"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMuscleDefaultMin(i)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.GetMuscleDefaultMin( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetMuscleDefaultMax"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMuscleDefaultMax(i)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.GetMuscleDefaultMax( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetBoneDefaultHierarchyMass"] = new BSFunctionReference(
                new BSFunction(
                    "function GetBoneDefaultHierarchyMass(i)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.GetBoneDefaultHierarchyMass(
                            WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetParentBone"] = new BSFunctionReference(
                new BSFunction(
                    "function GetParentBone(i)",
                    a => new BSObject(
                        ( decimal ) HumanTrait.GetParentBone( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
