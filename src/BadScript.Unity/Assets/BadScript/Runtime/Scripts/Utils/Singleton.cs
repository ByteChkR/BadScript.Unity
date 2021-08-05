using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace BadScript.Unity.Utils
{
    public abstract class Singleton<TSingleton> : MonoBehaviour
        where TSingleton : Singleton<TSingleton>
    {
        private static TSingleton instance;

        public static TSingleton Instance
        {
            get
            {
                // ReSharper disable once ConvertIfStatementToNullCoalescingExpression
                if (instance == null)
                {
                    GameObject singletonContainer = new GameObject($"{typeof(TSingleton).Name} singleton");
                    instance= singletonContainer.AddComponent<TSingleton>();
                }

                return instance;
            }
            private set => instance = value;
        }

        public static TSingleton InstanceIfInitialized => IsInitialized ? instance : null;

        public static bool IsInitialized => instance != null;

        protected virtual void Awake()
        {
            if (!IsInitialized)
            {
                Instance = this as TSingleton;
            }
            else
            {
                DestroyThis(false);

                throw new Exception( "Singleton Violation: " + typeof( TSingleton ).Name );
            }
        }

        protected virtual void OnDestroy()
        {
            if (instance == this)
            {
                instance = null;
            }
        }

        public void DontDestroyOnLoad(bool dontDestroy)
        {
            if (dontDestroy)
            {
                Object.DontDestroyOnLoad(instance.gameObject);
                return;
            }
            SceneManager.MoveGameObjectToScene(instance.gameObject, SceneManager.GetActiveScene());
        }

        /// <summary>
        /// Sets the instance of the singleton to null.
        /// </summary>
        public void DestroyInstance()
        {
            DestroyThis(true);
        }

        private void DestroyThis(bool destroyInstance)
        {
            if (destroyInstance)
            {
                instance = null;
            }

            if (gameObject.name.ToLower().Contains("singleton"))
            {
                Destroy(gameObject);
                return;
            }

            Destroy(this);
        }
    }
}
