using IPA;
using Microsoft.Win32;
using System.IO;
using UnityEngine;

namespace LeagueIsBadAndYouShouldBeSorry
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        [Init]
        public Plugin()
        {

        }

        [OnEnable]
        public void OnEnable()
        {
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Riot Games, Inc\League of Legends");

            if (key == null)
                return;

            if (Directory.Exists(key.GetValue("Location") as string))
                Application.Quit();
        }

        [OnDisable]
        public void OnDisable()
        {

        }
    }
}