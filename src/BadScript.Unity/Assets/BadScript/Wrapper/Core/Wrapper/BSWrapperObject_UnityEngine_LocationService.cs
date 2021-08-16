using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_LocationService : BSWrapperObject<UnityEngine.LocationService>

    {
        public BSWrapperObject_UnityEngine_LocationService(UnityEngine.LocationService obj) : base(obj)
        {
            m_Properties["isEnabledByUser"] = new BSReflectionReference(() => m_InternalObject.isEnabledByUser ? BSObject.One : BSObject.Zero, null);
            m_Properties["lastData"] = new BSReflectionReference(() => new BSWrapperObject_UnityEngine_LocationInfo(m_InternalObject.lastData), null);
            m_Properties["Start"] = new BSFunctionReference(new BSFunction("function Start(desiredAccuracyInMeters, updateDistanceInMeters)", a => {
                m_InternalObject.Start(WrapperHelper.UnwrapObject<System.Single>(a[0]), WrapperHelper.UnwrapObject<System.Single>(a[1]));
                return new BSObject(null);
            }, 2));
            m_Properties["Start"] = new BSFunctionReference(new BSFunction("function Start(desiredAccuracyInMeters)", a => {
                m_InternalObject.Start(WrapperHelper.UnwrapObject<System.Single>(a[0]));
                return new BSObject(null);
            }, 1));
            m_Properties["Start"] = new BSFunctionReference(new BSFunction("function Start()", a => {
                m_InternalObject.Start();
                return new BSObject(null);
            }, 0));
            m_Properties["Stop"] = new BSFunctionReference(new BSFunction("function Stop()", a => {
                m_InternalObject.Stop();
                return new BSObject(null);
            }, 0));
            m_Properties["Equals"] = new BSFunctionReference(new BSFunction("function Equals(obj)", a => m_InternalObject.Equals(WrapperHelper.UnwrapObject<System.Object>(a[0])) ? BSObject.One : BSObject.Zero, 1));
            m_Properties["GetHashCode"] = new BSFunctionReference(new BSFunction("function GetHashCode()", a => new BSObject((decimal)m_InternalObject.GetHashCode()), 0));
            m_Properties["ToString"] = new BSFunctionReference(new BSFunction("function ToString()", a => new BSObject(m_InternalObject.ToString()), 0));

        }
    }

}