using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Time : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Time() : base( typeof( Time ) )
        {
            m_StaticProperties["time"] = new BSReflectionReference( () => new BSObject( ( decimal ) Time.time ), null );

            m_StaticProperties["timeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeAsDouble ),
                null );

            m_StaticProperties["timeSinceLevelLoad"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeSinceLevelLoad ),
                null );

            m_StaticProperties["timeSinceLevelLoadAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeSinceLevelLoadAsDouble ),
                null );

            m_StaticProperties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.deltaTime ),
                null );

            m_StaticProperties["fixedTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedTime ),
                null );

            m_StaticProperties["fixedTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedTimeAsDouble ),
                null );

            m_StaticProperties["unscaledTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledTime ),
                null );

            m_StaticProperties["unscaledTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledTimeAsDouble ),
                null );

            m_StaticProperties["fixedUnscaledTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledTime ),
                null );

            m_StaticProperties["fixedUnscaledTimeAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledTimeAsDouble ),
                null );

            m_StaticProperties["unscaledDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.unscaledDeltaTime ),
                null );

            m_StaticProperties["fixedUnscaledDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedUnscaledDeltaTime ),
                null );

            m_StaticProperties["fixedDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.fixedDeltaTime ),
                x => Time.fixedDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["maximumDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.maximumDeltaTime ),
                x => Time.maximumDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["smoothDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.smoothDeltaTime ),
                null );

            m_StaticProperties["maximumParticleDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.maximumParticleDeltaTime ),
                x => Time.maximumParticleDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["timeScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.timeScale ),
                x => Time.timeScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["frameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.frameCount ),
                null );

            m_StaticProperties["renderedFrameCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.renderedFrameCount ),
                null );

            m_StaticProperties["realtimeSinceStartup"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.realtimeSinceStartup ),
                null );

            m_StaticProperties["realtimeSinceStartupAsDouble"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.realtimeSinceStartupAsDouble ),
                null );

            m_StaticProperties["captureDeltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.captureDeltaTime ),
                x => Time.captureDeltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["captureFramerate"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Time.captureFramerate ),
                x => Time.captureFramerate = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["inFixedTimeStep"] = new BSReflectionReference(
                () => Time.inFixedTimeStep ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
