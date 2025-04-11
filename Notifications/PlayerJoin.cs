using HarmonyLib;
using StupidTemplate.Notifications;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
//crab
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    //crab
    internal class JoinPatch : MonoBehaviour
    {
        private static void Prefix(Player newPlayer)
        {
            //crabcrabcrabcrabcrabcrabcrabcrabcrabcrabcrab
            if (newPlayer != oldnewplayer)
            {
                //crabcrabcrab
                NotifiLib.SendNotification("<color=grey>[</color><color=green>Join-Mr:</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
                oldnewplayer = newPlayer; //crabcrab
            }
        }

        //crabcrabcrabcrabcrabcrabcrabcrabcrabcrab
        private static Player oldnewplayer; //crabcrabcrabcrab
    }
    //crabcrabcrabcrabcrabcrabcrabcrabcrabcrabcrab
}
