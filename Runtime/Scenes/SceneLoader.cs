﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnitySnippets
{
    [AddComponentMenu("Unity Snippets/Scenes/Loader")]
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] string sceneName = "";
        [SerializeField] SignalObject onSceneReadySignal = null;

        AsyncOperation load = null;

        public void LoadScene()
        {
            StartCoroutine(LoadAsync());
        }

        public void ActivateScene()
        {
            if (load == null)
                return;
            load.allowSceneActivation = true;
        }

        IEnumerator LoadAsync()
        {
            load = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
            load.allowSceneActivation = false;
            while (load.progress < 0.9f)
            {
                yield return null;
            }
            if (onSceneReadySignal != null)
                onSceneReadySignal.CallSignal();
            Debug.Log("Loaded: " + sceneName);
        }
    }
}
