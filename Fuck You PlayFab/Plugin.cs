using BepInEx;
using GorillaNetworking;
using HarmonyLib;
using UnityEngine;

namespace Fuck_You_PlayFab
{
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony(Constants.GUID);
            harmony.PatchAll();
            Debug.Log("Fuck You PlayFab Loaded!");
        }
    }

    [HarmonyPatch(typeof(PlayFabAuthenticator), "Awake")]
    public class MainPatch
    {
        public static bool Prefix(PlayFabAuthenticator __instance)
        {
            Debug.Log("Blocked PlayFab Authenticator!");
            return false;
        }
    }
}