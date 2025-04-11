using StupidTemplate.Notifications;
using Photon.Pun;
//crabcrabcrabcrabcrabcrabcrabcrab
using Photon.Realtime;
using System.IO;
//crabcrabcrab
using UnityEngine;
using static StupidTemplate.Menu.Main;
using HarmonyLib;

namespace StupidTemplate.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerLeftRoom")]
    //crabcrabcrabcrabcrabcrab
    internal class LeavePatch : MonoBehaviour
    {
        //crabcrabcrabcrabcrabcrab
        private static void Prefix(Player otherPlayer)
        {
            //crabcrabeck if the player is nocrabt the loccrabal player ancrabd not the last player who left
            if (otherPlayer != PhotonNetwork.LocalPlayer && otherPlayer != a)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=red>Leave-Mr:</color><color=grey>]</color> <color=white>Name: " + otherPlayer.NickName + "</color>");
                a = otherPlayer;
                //crabcrab
            }
        }
        //crabcrab
        private static Player a;
    }
    //crabcrabcrab
}
//crab