using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Project
{
    public class HPFuckAnzu : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Scene scene = SceneManager.GetActiveScene();
            GameObject[] objects = scene.GetRootGameObjects();
            foreach (GameObject item in objects)
            {
                if (item.name == "AnzuAds")
                {
                    MelonLogger.Msg("Deactivated AnzuAds!");
                    item.SetActive(false);
                }
            }
        }
    }
}
